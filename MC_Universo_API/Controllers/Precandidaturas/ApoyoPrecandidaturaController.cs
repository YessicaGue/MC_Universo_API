using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using AutoMapper;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office.CoverPageProps;
using MC_Universo_API.Data;
using MC_Universo_API.Migrations;
using MC_Universo_API.Models;
using MC_Universo_API.Models.Precandidaturas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Text.RegularExpressions;

namespace MC_Universo_API.Controllers.Precandidaturas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApoyoPrecandidaturaController(UniversoContext context, IMapper mapper) : ControllerBase
    {
        [HttpGet("[action]")]
        public async Task<IActionResult> GetFullList()
        {
            try
            {
                var httpClient = new HttpClient();
                const string endpoint =
                    "https://flaskapimc.blackrock-483c688e.eastus.azurecontainerapps.io/get_all_apoyos_excel";

                var response = await httpClient.GetAsync(endpoint);
                if (!response.IsSuccessStatusCode)
                {
                    // Log the error or return a more specific error message
                    return BadRequest(
                        $"Error: {response.StatusCode}. No es posible descargar el archivo, debido a {response}");
                }

                var contentStream = await response.Content.ReadAsStreamAsync();
                const string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

                var fileName = response.Content.Headers.ContentDisposition?.FileName ??
                               $"firmas_{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.xlsx";
                return File(contentStream, contentType, fileName);
            }
            catch (Exception ex)
            {
                // Log the exception details
                // You can log ex.Message, ex.StackTrace, or any other details you need
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("GetFirmasCandidato")]
        public async Task<IActionResult> GetFirmasCandidato(
            [FromQuery] int perfilId
        )
        {
            var result = await ObtenerRespaldosPorPerfil(perfilId);
            return Ok(result);
        }

        [HttpGet("GetRespaldoPorCandidato")]
        public async Task<IActionResult> GetRespaldoPorCandidato(
            [FromQuery] int perfilId
        )
        {
            try
            {
                var result = await ObtenerRespaldosPorPerfil(perfilId);

                var dataPrecandidato = await context.PerfilPrecandidatura
                    .Where(perfilPrecandidatura => perfilPrecandidatura.PerfilId == perfilId)
                    .Join(context.CatalogoTipoPrecandidatura,
                        perfilPrecandidatura => perfilPrecandidatura.TipoPrecandidaturaId,
                        tipoPrecandidatura => tipoPrecandidatura.Id,
                        (perfilPrecandidatura, tipoPrecandidatura) => new { perfilPrecandidatura, tipoPrecandidatura })
                    .Join(context.PerfilUsuario,
                        perfilConPrecandidatura => perfilConPrecandidatura.perfilPrecandidatura.PerfilId,
                        perfilUsuario => perfilUsuario.PerfilId,
                        (perfilConPrecandidatura, perfilUsuario) => new { perfilConPrecandidatura, perfilUsuario })
                    // Entidad Federativa
                    .GroupJoin(context.EntidadFederativa, // Left join con EntidadFederativa
                        perfilConPrecandidatura => perfilConPrecandidatura.perfilConPrecandidatura.perfilPrecandidatura
                            .EntidadFederativaId,
                        entidadFederativa => entidadFederativa.Id,
                        (perfilConPrecandidatura, entidadFederativa) => new
                            { perfilConPrecandidatura, entidadFederativa = entidadFederativa.DefaultIfEmpty() })
                    .SelectMany(
                        x => x.entidadFederativa,
                        (x, entidadFederativa) => new
                        {
                            TipoPrecandidatura = x.perfilConPrecandidatura.perfilConPrecandidatura.tipoPrecandidatura
                                .Nombre,
                            EntidadFederativa = entidadFederativa != null ? entidadFederativa.Nombre : "N/A",
                            Distrito =
                                x.perfilConPrecandidatura.perfilConPrecandidatura.perfilPrecandidatura.Distrito != null
                                    ? x.perfilConPrecandidatura.perfilConPrecandidatura.perfilPrecandidatura.Distrito
                                        .ToString()
                                    : "N/A",
                            NombrePrecandidato = x.perfilConPrecandidatura.perfilUsuario.Name
                        })
                    .FirstOrDefaultAsync();

                if (dataPrecandidato == null)
                {
                    return BadRequest("No se encontró el perfil solicitado");
                }

                Console.WriteLine($"Result: {result.Count}");

                var workbook = new XLWorkbook();

                var sheet = workbook.Worksheets.Add("Respaldos");

                sheet.Range("A1:C1").Merge();
                sheet.Range("A1:C1").Value = "FORMATO DE RESPALDO A";
                sheet.Range("A1:C1").Style.Fill.BackgroundColor = XLColor.FromHtml("#ED7D31");
                sheet.Range("A1:C1").Style.Font.FontColor = XLColor.FromHtml("#FFFFFF");
                sheet.Range("A1:C1").Style.Font.FontSize = 22;
                sheet.Range("A1:C1").Style.Font.Bold = false;
                sheet.Range("A1:C1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                var range2 = "D1:G1";
                sheet.Range(range2).Merge();
                sheet.Range(range2).Value = $"LA PRECANDIDATURA A {dataPrecandidato.TipoPrecandidatura.ToUpper()}";
                sheet.Range(range2).Style.Font.FontColor = XLColor.FromHtml("#FFFFFF");
                sheet.Range(range2).Style.Font.Bold = true;
                sheet.Range(range2).Style.Font.FontSize = 22;
                sheet.Range(range2).Style.Fill.BackgroundColor = XLColor.FromHtml("#ED7D31");
                sheet.Range(range2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                var range3 = "A2:C2";
                sheet.Range(range3).Merge();
                sheet.Range(range3).Value = $"ENTIDAD: {dataPrecandidato.EntidadFederativa.ToUpper()}";
                sheet.Range(range3).Style.Font.FontColor = XLColor.FromHtml("#FFFFFF");
                sheet.Range(range3).Style.Font.Bold = true;
                sheet.Range(range3).Style.Font.FontSize = 22;
                sheet.Range(range3).Style.Fill.BackgroundColor = XLColor.FromHtml("#ED7D31");
                sheet.Range(range3).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                var range4 = "D2:F2";
                sheet.Range(range4).Merge();
                sheet.Range(range4).Value = $"DISTRITO: {dataPrecandidato.Distrito?.ToUpper()}";
                sheet.Range(range4).Style.Font.FontColor = XLColor.FromHtml("#FFFFFF");
                sheet.Range(range4).Style.Font.Bold = true;
                sheet.Range(range4).Style.Font.FontSize = 22;
                sheet.Range(range4).Style.Fill.BackgroundColor = XLColor.FromHtml("#ED7D31");
                sheet.Range(range4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                var range5 = "G2:G2";
                sheet.Range(range5).Merge();
                sheet.Range(range5).Value = $"{result.Count} FIRMAS";
                sheet.Range(range5).Style.Font.FontColor = XLColor.FromHtml("#FFFFFF");
                sheet.Range(range5).Style.Font.Bold = true;
                sheet.Range(range5).Style.Font.FontSize = 22;
                sheet.Range(range5).Style.Fill.BackgroundColor = XLColor.FromHtml("#ED7D31");
                sheet.Range(range5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                sheet.Range("A5:C5").Merge();
                sheet.Range("A5:C5").Value = "Nombre de la persona precandidata";
                sheet.Range("A5:C5").Style.Font.FontColor = XLColor.FromHtml("#ED7D31");
                sheet.Range("A5:C5").Style.Font.Bold = true;
                sheet.Range("A5:C5").Style.Font.FontSize = 16;

                sheet.Range("D5:G5").Merge();
                sheet.Range("D5:G5").Value = dataPrecandidato.NombrePrecandidato;
                sheet.Range("D5:G5").Style.Font.Bold = true;
                sheet.Range("D5:G5").Style.Font.FontSize = 16;

                var rowHeader = 7;

                string[] columnNames =
                [
                    "Nombre completo de la persona que respalda la candidatura",
                    "Sección electoral",
                    "Clave de elector de la credencial para votar",
                    "Teléfono",
                    "Correo electrónico",
                    "¿Acepta envío de información?",
                    "Firma"
                ];

                for (int i = 0; i < columnNames.Length; i++)
                {
                    sheet.Cell(rowHeader, i + 1).Value = columnNames[i];
                    sheet.Cell(rowHeader, i + 1).Style.Font.FontColor = XLColor.FromHtml("#FFFFFF");
                    sheet.Cell(rowHeader, i + 1).Style.Font.Bold = true;
                    sheet.Cell(rowHeader, i + 1).Style.Font.FontSize = 12;
                    sheet.Cell(rowHeader, i + 1).Style.Fill.BackgroundColor = XLColor.FromHtml("#ED7D31");
                    sheet.Cell(rowHeader, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                    sheet.Cell(rowHeader, i + 1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    sheet.Cell(rowHeader, i + 1).Style.Alignment.WrapText = true;
                }

                var row = 8;
                if (result.Count > 0)
                {
                    foreach (var respaldo in result)
                    {
                        sheet.Cell(row, 1).Value = respaldo.Formulario?.Nombre;
                        sheet.Cell(row, 2).Value = respaldo.Formulario?.Seccion;
                        sheet.Cell(row, 3).Value = respaldo.ClaveElector;
                        sheet.Cell(row, 4).Value = respaldo.NumeroTelefono;
                        sheet.Cell(row, 5).Value = respaldo.Email;
                        sheet.Cell(row, 6).Value =
                            respaldo.Formulario?.InformacionAdicionalAceptado ?? false ? "Sí" : "No";
                        sheet.Cell(row, 7).Value = respaldo.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
                        row++;
                    }
                }
                else
                {
                    sheet.Cell(row, 1).Value = "No hay firmas para este perfil";
                    row++;
                }

                row += 3;

                // Aviso de Privacidad
                sheet.Range($"A{row}:G{row}").Merge();
                sheet.Range($"A{row}:G{row}").Value = "Aviso de Privacidad";
                sheet.Range($"A{row}:G{row}").Style.Font.FontColor = XLColor.FromHtml("#FFFFFF");
                sheet.Range($"A{row}:G{row}").Style.Font.Bold = true;
                sheet.Range($"A{row}:G{row}").Style.Font.FontSize = 16;
                sheet.Range($"A{row}:G{row}").Style.Fill.BackgroundColor = XLColor.FromHtml("#ED7D31");
                sheet.Range($"A{row}:G{row}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                sheet.Row(row).Height = 30;
                sheet.Row(row).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                row++;
                sheet.Range($"A{row}:G{row}").Merge();
                sheet.Range($"A{row}:G{row}").Value = "FORMATO DSDP-S14CIURESCANP-Al2";
                sheet.Range($"A{row}:G{row}").Style.Font.FontColor = XLColor.Gray;
                sheet.Range($"A{row}:G{row}").Style.Font.Bold = false;
                sheet.Range($"A{row}:G{row}").Style.Font.FontSize = 14;
                sheet.Range($"A{row}:G{row}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                sheet.Row(row).Height = 20;
                sheet.Row(row).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                row++;
                sheet.Range($"A{row}:G{row}").Merge();
                sheet.Range($"A{row}:G{row}").Value = "Movimiento Ciudadano, con domicilio en Louisiana No 113, " +
                                                      "Colonia Nápoles, Alcaldía Benito Juárez, C.P. 03810, Ciudad de México, es responsable del tratamiento de los datos personales que nos proporcione, los cuales serán protegidos conforme a lo dispuesto por la Ley General de Protección de Datos Personales en Posesión de Sujetos Obligados y demás normatividad que resulte aplicable." +
                                                      "Los datos recabados en el formato de respaldo de la precandidatura, los utilizaremos para las siguientes finalidades:" +
                                                      "• Verificar y confirmar su identidad, así como la autenticidad de la información que nos proporciona." +
                                                      "• Integrar expedientes y bases de datos necesarias para registrar, concentrar y consultar a las y los ciudadanos que respaldan las precandidaturas en Movimiento Ciudadano." +
                                                      "• Tener un medio de comunicación con las personas que respaldan las precandidaturas de Movimiento Ciudadano para proporcionarles información, de nuestras actividades y propuestas." +
                                                      "• Adicionalmente, se utilizarán única y exclusivamente para fines estadísticos e informes, la información no estará asociada con la persona titular de los datos personales, por tanto, no será posible asociarlo con ella y en consecuencia no será posible identificarle. Se informa además que, los datos personales recabados no serán transferidos por Movimiento" +
                                                      "solicite, ésta debe estar debidamente fundada y motivada. Para llevar a cabo las finalidades descritas en el presente aviso de privacidad, utilizaremos datos personales de identificación y contacto. Si desea mayor información sobre los términos y condiciones en que éstos serán tratados, puede consultar el aviso de privacidad integral del Sistema de Personas Ciudadanas que Respaldan las Precandidaturas en " +
                                                      "https://transparencia.movimientociudadano.mx/protecciondedatospersonales";
                sheet.Range($"A{row}:G{row}").Style.Font.FontColor = XLColor.SlateGray;
                sheet.Range($"A{row}:G{row}").Style.Font.Bold = false;
                sheet.Range($"A{row}:G{row}").Style.Font.FontSize = 10;
                sheet.Range($"A{row}:G{row}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                sheet.Range($"A{row}:G{row}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
                sheet.Range($"A{row}:G{row}").Style.Alignment.WrapText = true;
                sheet.Row(row).Height = 120;

                // Agregar logo
                var pathToImage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppAssets", "logo_mc.png");
                await using (var imageStream = System.IO.File.OpenRead(pathToImage))
                {
                    row += 2;
                    var picture = sheet.AddPicture(imageStream)
                        .MoveTo(sheet.Cell(row, 4))
                        .WithSize(336, 209)
                        .Scale(0.35);

                    sheet.Row(row).Height = 60;
                    sheet.Range($"A{row}:G{row}").Merge();
                    sheet.Range($"A{row}:G{row}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    sheet.Range($"A{row}:G{row}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                }

                // Adjust height of row
                sheet.Row(1).Height = 50;
                sheet.Row(2).Height = 50;

                // Adjust column width to fit the longest string in the column
                for (var i = 1; i <= 7; i++)
                {
                    sheet.Column(i).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                    sheet.Column(i).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    sheet.Column(i).Style.Alignment.WrapText = true;
                    sheet.Column(i).Width = i == 1 ? 50 : i == 7 ? 50 : 35;
                }

                using var stream = new MemoryStream();
                workbook.SaveAs(stream);
                var content = stream.ToArray();

                var nameFile =
                    $"respaldo-{RemoveAccents(dataPrecandidato.TipoPrecandidatura.Replace(' ', '_'))}-{RemoveAccents(dataPrecandidato.NombrePrecandidato.Replace(' ', '_'))}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.xlsx";

                return File(
                    content,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    nameFile
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApoyoPrecandidatura>>> Get()
        {
            try
            {
                var conteoPorTipoPrecandidatura = await ObtenerDatosPorTipoPrecandidatura();

                return Ok(conteoPorTipoPrecandidatura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetPrecandidatosCeros")]
        public async Task<ActionResult<IEnumerable<ApoyoPrecandidatura>>> GetPrecandidatosCeros()
        {
            try
            {
                var conteoPorTipoPrecandidatura = await ObtenerDatosPorTipoPrecandidaturaCeros();

                return Ok(conteoPorTipoPrecandidatura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("export-to-excel")]
        public async Task<IActionResult> FirmasExportToExcel()
        {
            var data = await ObtenerDatosPorTipoPrecandidatura();

            var workbook = new XLWorkbook();

            foreach (var tipo in data)
            {
                var sheetNameTmp = tipo.TipoPrecandidatura.Replace(" ", "-").ToLower();
                sheetNameTmp = sheetNameTmp.Length > 25 ? sheetNameTmp.Substring(0, 25) : sheetNameTmp;
                var sheet = workbook.Worksheets.Add(sheetNameTmp);
                sheet.Cell(1, 1).Value = "Perfil ID";
                sheet.Cell(1, 2).Value = "Alias";
                sheet.Cell(1, 3).Value = "Email";
                sheet.Cell(1, 4).Value = "Nombre";
                sheet.Cell(1, 5).Value = "Conteo";

                var row = 2;
                foreach (var perfil in tipo.Perfiles)
                {
                    sheet.Cell(row, 1).Value = perfil.PerfilId;
                    sheet.Cell(row, 2).Value = perfil.Alias;
                    sheet.Cell(row, 3).Value = perfil.Email;
                    sheet.Cell(row, 4).Value = perfil.Nombre;
                    sheet.Cell(row, 5).Value = perfil.Conteo;
                    row++;
                }
            }

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            var content = stream.ToArray();

            var nameFile = $"firmas-{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.xlsx";

            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                nameFile
            );
        }

        [HttpGet("export-to-excel-ceros")]
        public async Task<IActionResult> FirmasExportToExcelCeros()
        {
            var data = await ObtenerDatosPorTipoPrecandidaturaCeros();

            var workbook = new XLWorkbook();

            foreach (var tipo in data)
            {
                var sheetNameTmp = tipo.TipoPrecandidatura.Replace(" ", "-").ToLower();
                sheetNameTmp = sheetNameTmp.Length > 25 ? sheetNameTmp.Substring(0, 25) : sheetNameTmp;
                var sheet = workbook.Worksheets.Add(sheetNameTmp);
                sheet.Cell(1, 1).Value = "Perfil ID";
                sheet.Cell(1, 2).Value = "Alias";
                sheet.Cell(1, 3).Value = "Email";
                sheet.Cell(1, 4).Value = "Nombre";
                sheet.Cell(1, 5).Value = "Conteo";

                var row = 2;
                foreach (var perfil in tipo.Perfiles)
                {
                    sheet.Cell(row, 1).Value = perfil.PerfilId;
                    sheet.Cell(row, 2).Value = perfil.Alias;
                    sheet.Cell(row, 3).Value = perfil.Email;
                    sheet.Cell(row, 4).Value = perfil.Nombre;
                    sheet.Cell(row, 5).Value = perfil.Conteo;
                    row++;
                }
            }

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            var content = stream.ToArray();

            var nameFile = $"firmas-ceros-{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.xlsx";

            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                nameFile
            );
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ApoyoPrecandidatura>> Get(int id)
        {
            var apoyoPrecandidatura = await context.ApoyoPrecandidatura.FindAsync(id);

            return apoyoPrecandidatura == null ? NotFound() : apoyoPrecandidatura;
        }

        [HttpPost]
        public async Task<ActionResult<ApoyoPrecandidatura>> Post(ApoyoPrecandidaturaViewModel request)
        {
            try
            {
                var apoyoPrecandidatura = mapper.Map<ApoyoPrecandidatura>(request);
                context.ApoyoPrecandidatura.Add(apoyoPrecandidatura);
                await context.SaveChangesAsync();

                return CreatedAtAction("Get", new { id = apoyoPrecandidatura.Id }, apoyoPrecandidatura);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 2601)
                {
                    throw new Exception("Ya existe un registro con la misma clave de elector para este candidato.", ex);
                }
                else
                {
                    throw;
                }
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, ApoyoPrecandidaturaViewModel request)
        {
            var apoyoPrecandidatura = await context.ApoyoPrecandidatura.FindAsync(id);

            if (apoyoPrecandidatura == null)
            {
                return NotFound();
            }

            mapper.Map(request, apoyoPrecandidatura);
            await context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = apoyoPrecandidatura.Id }, apoyoPrecandidatura);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var apoyoPrecandidatura = await context.ApoyoPrecandidatura.FindAsync(id);

            if (apoyoPrecandidatura == null)
            {
                return NotFound();
            }

            context.ApoyoPrecandidatura.Remove(apoyoPrecandidatura);
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("disable/{id:int}")]
        public async Task<IActionResult> Disable(int id)
        {
            var apoyoPrecandidatura = await context.ApoyoPrecandidatura.FindAsync(id);

            if (apoyoPrecandidatura == null)
            {
                return NotFound();
            }

            apoyoPrecandidatura.Activo = false;
            apoyoPrecandidatura.FechaActualizacion = DateTime.UtcNow;
            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("is_any_by")]
        public bool AnyBy(
            [FromQuery] int perfilId,
            [FromQuery] string clave
        )
        {
            if (perfilId == 0 || string.IsNullOrEmpty(clave))
            {
                return false;
            }

            return context.ApoyoPrecandidatura
                .Any(apoyo => apoyo.PerfilId == perfilId && apoyo.ClaveElector == clave);
        }

        [HttpGet("is_count_below_limit")]
        public bool CountIsBelow(
            [FromQuery] string? email,
            [FromQuery] string? numeroTelefono,
            [FromQuery] int countLimit
        )
        {
            if ((string.IsNullOrEmpty(email) && string.IsNullOrEmpty(numeroTelefono)) || countLimit <= 0)
            {
                return false;
            }
            
            try
            {
                var totalCount = context.ApoyoPrecandidatura
                    .Count(apoyo =>
                        (email != null && apoyo.Email == email) ||
                        (numeroTelefono != null && apoyo.NumeroTelefono == numeroTelefono));
                return totalCount < countLimit;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return true;
            }
        }
        
        [HttpGet("obtenerFirmantes/porGuid/{guid}")]
        public async Task<ActionResult<PaginatedResponse<FirmantesDto>>> GetApoyos(Guid guid,int pageNumber = 1, int pageSize = 1000)
        {
            try
            {
                pageNumber = pageNumber < 1 ? 1 : pageNumber;
                pageSize = pageSize < 1 ? 1 : pageSize > 1000 ? 1000 : pageSize;
                
                var totalItems = await context.ApoyoPrecandidatura
                    .Where(x => x.Perfil.Guid == guid) // Asumiendo que 'Guid' es una propiedad de tipo string en 'Perfil'
                    .CountAsync();
                
                var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
                
                var items = await context.ApoyoPrecandidatura
                    .Where(x => x.Perfil.Guid == guid)
                    .Join(context.PerfilPrecandidatura,
                        apoyo => apoyo.Perfil.Id, // Asegúrate de que esta es la clave correcta
                        perfilPrecandidatura => perfilPrecandidatura.PerfilId, // y que coincide con esta
                        (apoyo, perfilPrecandidatura) => new // Creando un nuevo objeto anónimo
                        {   
                            Id = apoyo.Id,
                            Email = apoyo.Email,
                            NumeroTelefono = apoyo.NumeroTelefono,
                            ClaveElector = apoyo.ClaveElector,
                            EstaInteresadoInformacionAdicional = apoyo.EstaInteresadoInformacionAdicional,
                            FormularioRellenadoJSON = apoyo.FormularioRellenadoJSON,
                            EntidadFederativaNombre = perfilPrecandidatura.EntidadFederativa.Nombre // Asumiendo que quieres incluir esta información
                        })
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
                
                var firmantesDto = items.Select(x => {
                    var nombre = "N/A"; // Valor predeterminado en caso de que no se pueda extraer el nombre
                    if (!string.IsNullOrEmpty(x.FormularioRellenadoJSON))
                    {
                        try
                        {
                            var formulario = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(x.FormularioRellenadoJSON);
                            if (formulario?.ContainsKey("nombre") == true)
                            {
                                nombre = formulario["nombre"].GetString();
                            }
                        }
                        catch (JsonException) // Captura cualquier error durante la deserialización
                        {
                            nombre = "N/A";
                        }
                    }
                    
                    // Limpia el número de teléfono antes de usarlo para la URL de WhatsApp
                    var numeroTelefonoLimpio = x.NumeroTelefono != null ? Regex.Replace(x.NumeroTelefono, "[^0-9]", "") : null;
                    
                    return new FirmantesDto
                    {
                        Id = x.Id,
                        Nombre = nombre != null ? nombre.ToUpperInvariant():"N/A", // Usa el nombre extraído del formulario
                        Estado = x.EntidadFederativaNombre,
                        Correo = x.Email != null ? x.Email.ToLowerInvariant() : "N/A",
                        NumeroTelefono = x.NumeroTelefono != null ? x.NumeroTelefono : "N/A",
                        UrlWhatsapp = x.NumeroTelefono != null ? $"https://api.whatsapp.com/send?phone=52{numeroTelefonoLimpio}" : null,
                        UrlCorreo = x.Email != null ? $"mailto:{x.Email.ToLowerInvariant()}" : null,
                        ClaveElector = x.ClaveElector,
                        EstaInteresadoInformacionAdicional = x.EstaInteresadoInformacionAdicional,
                    };
                }).ToList();
                
                var response = new PaginatedResponse<FirmantesDto>
                {
                    Items = firmantesDto,
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    PageNumber = pageNumber,
                    PageSize = pageSize
                };

                return Ok(response);
            }catch(Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
        
        [HttpPut("confirmar/confirmacion&{confirmacion:bool}/registro&{id:int}/email&{email}")]
        public async Task<IActionResult> ConfirmarRegistro(bool confirmacion, int id, string email)
        {
            var apoyoPrecandidatura =
                await context.ApoyoPrecandidatura.SingleOrDefaultAsync(up => up.Id == id && up.Email == email);

            if (apoyoPrecandidatura == null)
            {
                return NotFound("Registro No Encontrado");
            }

            apoyoPrecandidatura.ConfirmacionRegistro = confirmacion;
            apoyoPrecandidatura.FechaActualizacion = DateTime.UtcNow;
            await context.SaveChangesAsync();
            return Ok("Confirmación Exitosa");
        }
        
        public class PaginatedResponse<T>
        {
            public IEnumerable<T> Items { get; set; }
            public int TotalItems { get; set; }
            public int TotalPages { get; set; }
            public int PageNumber { get; set; }
            public int PageSize { get; set; }
        }
        
        public class FirmantesDto
        {
            public int? Id { get; set; }
            public string? Nombre { get; set; }
            public string? Estado { get; set; }
            public string? Correo { get; set; }
            public string? NumeroTelefono { get; set; }
            public string? UrlWhatsapp { get; set; }
            public string? UrlCorreo { get; set; }
            
            public string? ClaveElector { get; set; }
            
            public bool? EstaInteresadoInformacionAdicional { get; set; }
            
        }

        // Utils *******************************************************************************************************
        private Task<List<TipoPrecandidaturaData>> ObtenerDatosPorTipoPrecandidatura()
        {
            return context.ApoyoPrecandidatura
                .Where(apoyo => apoyo.Activo)
                .Join(context.Perfil, // Unir con Perfil
                    apoyo => apoyo.PerfilId,
                    perfil => perfil.Id,
                    (apoyo, perfil) => new { Apoyo = apoyo, Perfil = perfil })
                .Join(context.PerfilPrecandidatura, // Unir con PerfilPrecandidatura
                    apoyoConPerfil => apoyoConPerfil.Perfil.Id,
                    perfilPrecandidatura => perfilPrecandidatura.PerfilId,
                    (apoyoConPerfil, perfilPrecandidatura) => new
                        { ApoyoConPerfil = apoyoConPerfil, PerfilPrecandidatura = perfilPrecandidatura })
                .Where(apoyoConPerfil => apoyoConPerfil.PerfilPrecandidatura.Activo)
                .Join(context.CatalogoTipoPrecandidatura, // Unir con CatalogoTipoPrecandidatura
                    apoyoConPerfil => apoyoConPerfil.PerfilPrecandidatura.TipoPrecandidaturaId,
                    tipoPrecandidatura => tipoPrecandidatura.Id,
                    (apoyoConPerfil, tipoPrecandidatura) => new
                        { ApoyoConPerfil = apoyoConPerfil, TipoPrecandidatura = tipoPrecandidatura })
                .Join(context.PerfilUsuario, // Unir con PerfilUsuario
                    apoyoConPerfil => apoyoConPerfil.ApoyoConPerfil.ApoyoConPerfil.Perfil.Id,
                    perfilUsuario => perfilUsuario.PerfilId,
                    (apoyoConPerfil, perfilUsuario) => new
                        { ApoyoConPerfil = apoyoConPerfil, PerfilUsuario = perfilUsuario })
                .GroupBy(ap => ap.ApoyoConPerfil.TipoPrecandidatura.Nombre) // Agrupar por tipo de precandidatura
                .Select(group => new TipoPrecandidaturaData
                {
                    TipoPrecandidatura = group.Key,
                    Perfiles = group
                        .GroupBy(p => p.ApoyoConPerfil.ApoyoConPerfil.ApoyoConPerfil.Perfil.Id)
                        .Select(subGroup => new PerfilData
                        {
                            PerfilId = subGroup.Key,
                            Alias =
                                subGroup.FirstOrDefault()!.ApoyoConPerfil.ApoyoConPerfil.ApoyoConPerfil.Perfil.Alias,
                            Email = subGroup.FirstOrDefault()!.PerfilUsuario.Email,
                            Nombre = subGroup.FirstOrDefault()!.PerfilUsuario.Name,
                            Conteo = subGroup.Count(),
                            EntidadFederativa = subGroup.FirstOrDefault() != null && subGroup.FirstOrDefault()!
                                .ApoyoConPerfil.ApoyoConPerfil.PerfilPrecandidatura.EntidadFederativa != null
                                ? subGroup.FirstOrDefault()!.ApoyoConPerfil.ApoyoConPerfil.PerfilPrecandidatura
                                    .EntidadFederativa!.Nombre
                                : "N/A",
                        })
                        .OrderByDescending(p => p.Conteo)
                        .ToList()
                })
                .ToListAsync();
        }

        private Task<List<TipoPrecandidaturaData>> ObtenerDatosPorTipoPrecandidaturaCeros()
        {
            return context.PerfilPrecandidatura
                .Where(perfilPrecandidatura =>
                    perfilPrecandidatura.Activo) // Asegúrate de que PerfilPrecandidatura esté activo
                .Join(context.Perfil, // Unir con Perfil
                    perfilPrecandidatura => perfilPrecandidatura.PerfilId,
                    perfil => perfil.Id,
                    (perfilPrecandidatura, perfil) =>
                        new { PerfilPrecandidatura = perfilPrecandidatura, Perfil = perfil })
                .GroupJoin(context.ApoyoPrecandidatura, // Unir con ApoyoPrecandidatura utilizando GroupJoin
                    perfilConPrecandidatura => perfilConPrecandidatura.Perfil.Id,
                    apoyo => apoyo.PerfilId,
                    (perfilConPrecandidatura, apoyos) => new { perfilConPrecandidatura, Apoyos = apoyos })
                .Where(perfilConApoyos =>
                    !perfilConApoyos.Apoyos.Any(apoyo => apoyo.Activo)) // Filtrar donde no haya apoyos activos
                .Join(context.CatalogoTipoPrecandidatura, // Unir con CatalogoTipoPrecandidatura
                    perfilConApoyos =>
                        perfilConApoyos.perfilConPrecandidatura.PerfilPrecandidatura.TipoPrecandidaturaId,
                    tipoPrecandidatura => tipoPrecandidatura.Id,
                    (perfilConApoyos, tipoPrecandidatura) => new
                    {
                        PerfilConPrecandidatura = perfilConApoyos.perfilConPrecandidatura,
                        TipoPrecandidatura = tipoPrecandidatura
                    })
                .Join(context.PerfilUsuario, // Unir con PerfilUsuario
                    perfilConApoyos => perfilConApoyos.PerfilConPrecandidatura.Perfil.Id,
                    perfilUsuario => perfilUsuario.PerfilId,
                    (perfilConApoyos, perfilUsuario) => new
                    {
                        PerfilConPrecandidatura = perfilConApoyos.PerfilConPrecandidatura,
                        PerfilUsuario = perfilUsuario,
                        TipoPrecandidatura = perfilConApoyos.TipoPrecandidatura
                    })
                .GroupBy(ap => ap.TipoPrecandidatura.Nombre) // Agrupar por tipo de precandidatura
                .Select(group => new TipoPrecandidaturaData
                {
                    TipoPrecandidatura = group.Key,
                    Perfiles = group
                        .Select(p => new PerfilData
                        {
                            PerfilId = p.PerfilConPrecandidatura.Perfil.Id,
                            Alias = p.PerfilConPrecandidatura.Perfil.Alias,
                            Email = p.PerfilUsuario.Email,
                            Nombre = p.PerfilUsuario.Name,
                            EntidadFederativa = p.PerfilConPrecandidatura.PerfilPrecandidatura.EntidadFederativa != null
                                ? p.PerfilConPrecandidatura.PerfilPrecandidatura.EntidadFederativa.Nombre
                                : "N/A"
                        })
                        .OrderByDescending(p => p.Nombre) // Ordenar según el criterio deseado
                        .ToList()
                })
                .ToListAsync();
        }

        private class TipoPrecandidaturaData
        {
            public string TipoPrecandidatura { get; set; } = "N/A";
            public List<PerfilData> Perfiles { get; set; } = [];
        }

        private class PerfilData
        {
            public int PerfilId { get; set; } = 0;
            public string? Alias { get; set; } = "N/A";
            public string Email { get; set; } = "N/A";
            public string Nombre { get; set; } = "N/A";
            public int Conteo { get; set; } = 0;
            public string? EntidadFederativa { get; set; } = "N/A";
        }

        // Apoyos por perfil
        private async Task<List<ApoyoPrecandidaturaDto>> ObtenerRespaldosPorPerfil(int perfilId)
        {
            var dataTmp = await context.ApoyoPrecandidatura
                .Where(ap => ap.Activo && ap.PerfilId == perfilId)
                .Join(context.PerfilUsuario,
                    apoyo => apoyo.PerfilId,
                    perfilUsuario => perfilUsuario.PerfilId,
                    (apoyo, perfilUsuario) => new { Apoyo = apoyo, PerfilUsuario = perfilUsuario })
                .Join(context.PerfilPrecandidatura,
                    apoyoConPerfil => apoyoConPerfil.Apoyo.PerfilId,
                    perfilPrecandidatura => perfilPrecandidatura.PerfilId,
                    (apoyoConPerfil, perfilPrecandidatura) => new
                        { ApoyoConPerfil = apoyoConPerfil, PerfilPrecandidatura = perfilPrecandidatura })
                .GroupJoin(context.EntidadFederativa, // Left join con EntidadFederativa
                    apoyoConPerfil => apoyoConPerfil.PerfilPrecandidatura.EntidadFederativaId,
                    entidadFederativa => entidadFederativa.Id,
                    (apoyoConPerfil, entidadFederativa) => new
                        { apoyoConPerfil, entidadFederativa = entidadFederativa.DefaultIfEmpty() })
                .SelectMany(
                    x => x.entidadFederativa,
                    (x, entidadFederativa) => new
                    {
                        Id = x.apoyoConPerfil.ApoyoConPerfil.Apoyo.Id,
                        Email = x.apoyoConPerfil.ApoyoConPerfil.Apoyo.Email,
                        NumeroTelefono = x.apoyoConPerfil.ApoyoConPerfil.Apoyo.NumeroTelefono,
                        ClaveElector = x.apoyoConPerfil.ApoyoConPerfil.Apoyo.ClaveElector,
                        FechaCreacion = x.apoyoConPerfil.ApoyoConPerfil.Apoyo.FechaCreacion,
                        NombrePrecandidato = x.apoyoConPerfil.ApoyoConPerfil.PerfilUsuario.Name,
                        EntidadFederativa = entidadFederativa != null ? entidadFederativa.Nombre : "N/A",
                        DistritoPrecandidato = x.apoyoConPerfil.PerfilPrecandidatura.Distrito != null
                            ? x.apoyoConPerfil.PerfilPrecandidatura.Distrito.ToString()
                            : "N/A",
                        FormularioRellenadoJSON = x.apoyoConPerfil.ApoyoConPerfil.Apoyo.FormularioRellenadoJSON
                    })
                .ToListAsync();


            var entidadesFederativas = await context.EntidadFederativa.ToDictionaryAsync(ef => ef.Id, ef => ef.Nombre);

            var dtoList = dataTmp.Select(ap =>
            {
                // Limpia el JSON si es necesario
                var json = new string(ap.FormularioRellenadoJSON.Where(c => !char.IsControl(c)).ToArray());
                FormularioRellenadoDto? formulario = null;

                try
                {
                    formulario = JsonSerializer.Deserialize<FormularioRellenadoDto>(json, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNameCaseInsensitive = true,
                    });
                }
                catch (JsonException ex)
                {
                    // Log the error
                    Console.WriteLine(
                        $"Error deserializing JSON for ApoyoPrecandidatura ID {ap.Id}: {ex.Message} | {ap.FormularioRellenadoJSON}");
                    // Handle the error as appropriate for your application
                }

                // Convertir el estado si es necesario
                if (formulario?.Estado != null && int.TryParse(formulario.Estado, out var estadoId) &&
                    entidadesFederativas.TryGetValue(estadoId, out var estadoNombre))
                {
                    formulario.Estado = estadoNombre;
                }

                return new ApoyoPrecandidaturaDto
                {
                    Id = ap.Id,
                    Email = ap.Email,
                    NumeroTelefono = ap.NumeroTelefono,
                    ClaveElector = ap.ClaveElector,
                    NombrePrecandidato = ap.NombrePrecandidato,
                    EntidadFederativaPrecandidato = ap.EntidadFederativa,
                    DistritoPrecandidato = ap.DistritoPrecandidato ?? "N/A",
                    FechaCreacion = ap.FechaCreacion,
                    Formulario = formulario
                };
            }).ToList();

            return dtoList;
        }

        private class ApoyoPrecandidaturaDto
        {
            public int Id { get; set; }

            public string? Email { get; set; } = "N/A";
            public string? NumeroTelefono { get; set; } = "N/A";
            public string? ClaveElector { get; set; } = "N/A";
            public string NombrePrecandidato { get; set; } = "N/A";
            public string EntidadFederativaPrecandidato { get; set; } = "N/A";
            public String DistritoPrecandidato { get; set; } = "N/A";
            public DateTime FechaCreacion { get; set; }
            public FormularioRellenadoDto? Formulario { get; set; }
        }

        protected class StringOrNumberConverter : JsonConverter<string>
        {
            public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);

                return document.RootElement.ValueKind switch
                {
                    JsonValueKind.String => document.RootElement.GetString(),
                    JsonValueKind.Number => document.RootElement.GetDouble().ToString(CultureInfo.CurrentCulture),
                    JsonValueKind.Null => "N/A",
                    JsonValueKind.Undefined => "N/A",
                    JsonValueKind.Array => "N/A",
                    JsonValueKind.True => "N/A",
                    JsonValueKind.False => "N/A",
                    JsonValueKind.Object => "N/A",
                    _ => throw new JsonException("Unexpected value kind: " + document.RootElement.ValueKind)
                } ?? "N/A";
            }

            public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value);
            }
        }

        public class FormularioRellenadoDto
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = "N/A";
            public string Numero { get; set; } = "N/A";
            public string Email { get; set; } = "N/A";
            public string Clave { get; set; } = "N/A";

            public bool AvisoAceptado { get; set; }
            public bool InformacionAdicionalAceptado { get; set; }

            public int? Distrito { get; set; } = 0;
            public string? Seccion { get; set; } = "N/A";

            [JsonConverter(typeof(StringOrNumberConverter))]
            public string? Estado { get; set; } = "N/A";

            public CatalogoTipoPrecandidatura TipoPrecandidatura { get; set; } = default!;
            public Perfil PerfilPrecandidatura { get; set; } = default!;
        }

        [HttpGet("for-export")]
        public object GetForExport([FromQuery] Guid guid)
        {
            var perfil = context.Perfil
                .Where(perfil => guid == perfil.Guid)
                .FirstOrDefault();

            if (perfil == null)
            {
                return NotFound();
            }

            var firmas = context.ApoyoPrecandidatura
                .Where(firma => perfil.Id == firma.PerfilId)
                .Select(firma =>
                    new
                    {
                        firma.Id,
                        firma.PerfilId,
                        firma.TipoPrecandidaturaId,
                        firma.Email,
                        firma.NumeroTelefono,
                        firma.ClaveElector,
                        firma.EstaInteresadoInformacionAdicional,
                        formularioRellenadoObject = JsonSerializer.Deserialize<FormularioRellenadoDto>(
                            firma.FormularioRellenadoJSON,
                            new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                PropertyNameCaseInsensitive = true,
                            }
                        ),
                    }
                )
                .Select(firma =>
                    new
                    {
                        firma.Id,
                        firma.PerfilId,
                        firma.TipoPrecandidaturaId,
                        firma.Email,
                        firma.NumeroTelefono,
                        firma.ClaveElector,
                        firma.EstaInteresadoInformacionAdicional,
                        nombre = firma.formularioRellenadoObject != null
                            ? firma.formularioRellenadoObject.Nombre
                            : "",
                        seccion = firma.formularioRellenadoObject != null
                            ? firma.formularioRellenadoObject.Seccion
                            : "",
                        precandidatura = context.CatalogoTipoPrecandidatura
                            .Where(tipo =>
                                firma.TipoPrecandidaturaId == tipo.Id
                                    && tipo.Activo == true
                            )
                            .FirstOrDefault(),
                        perfil = context.Perfil
                            .Where(perfil =>
                                firma.PerfilId == perfil.Id
                                    && perfil.Activo == true
                            )
                            .Select(perfil =>
                                new
                                {
                                    perfil.Alias,
                                    ubicacion = context.PerfilPrecandidatura
                                        .Where(perfilPrecandidato =>
                                            perfil.Id == perfilPrecandidato.PerfilId
                                                && perfilPrecandidato.Activo == true
                                        )
                                        .Select(perfilPrecandidato =>
                                            new
                                            {
                                                perfilPrecandidato.Municipio,
                                                estado = context.EntidadFederativa
                                                    .Where(estado => perfilPrecandidato.EntidadFederativaId == estado.Id)
                                                    .FirstOrDefault()
                                            }
                                        )
                                        .FirstOrDefault(),
                                }
                            )
                            .FirstOrDefault(),
                    }
                )
                .ToList();

            return firmas
                .ToList()
                .Take(100);
        }

        public static string RemoveAccents(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}