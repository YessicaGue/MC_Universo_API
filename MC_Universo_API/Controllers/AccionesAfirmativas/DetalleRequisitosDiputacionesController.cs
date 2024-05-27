using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels.AccionesAfirmativasViewModels;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Completion;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers.AccionesAfirmativas
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleRequisitosDiputacionesController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public DetalleRequisitosDiputacionesController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<DetalleRequisitosDiputacionesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleRequisitoDiputaciones>>> Get()
        {
            return await _context.DetalleRequisitoDiputaciones.ToListAsync();
        }

        // GET api/<DetalleRequisitosDiputacionesController>/5
        [HttpPost]
        public async Task<ActionResult<DetalleRequisitoDiputaciones>> Post(DetalleRequisitoDiputacionesViewModel request)
        {
            DetalleRequisitoDiputaciones detalleRequisitoDiputaciones = _mapper.Map<DetalleRequisitoDiputaciones>(request);
            _context.DetalleRequisitoDiputaciones.Add(detalleRequisitoDiputaciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = detalleRequisitoDiputaciones.Id }, detalleRequisitoDiputaciones);
        }

        //Get api/<DetalleRequisitoDiputacionesController>/5
        [HttpGet("FiltroPor/circunscripcion/{circunscripcion}/representante/{representante}")]
        public async Task<IActionResult> ObtenerFiltroPorEstadoCircunscripcion(string circunscripcion, string representante)
        {
            int? circunscripcionId = null;
            int? representanteId = null;
            if (circunscripcion.Length == 8 && representante.Length == 8)
            {
                circunscripcionId = _context.CatalogoCircunscripcion
                    .Where(cc => cc.ShortId == circunscripcion)
                    .Select(cc => cc.Id)
                    .FirstOrDefault();

                representanteId = _context.CatalogoRepresentante
                    .Where(cc => cc.ShortId == representante)
                    .Select(cc => cc.Id)
                    .FirstOrDefault();
            }

            var catalogoRepresentante = _context.CatalogoRepresentante
                .Where(cc => cc.Id == representanteId)
                .ToList();

            //obtenemosCircunscripcion
            var estados = _context.EstadoCircunscripcion
                .Where(ec => ec.CircunscripcionId == circunscripcionId)
                .Select(ec => ec.EntidadFederativa)
                .ToList();

            var distritosCompetenciaBaja = new List<DistritosFederales>();
            var distritosCompetenciaMedia = new List<DistritosFederales>();
            var distritosCompetenciaAlta = new List<DistritosFederales>();
            var candidatosExistentesBloqueAlta = new List<CandidatoPersona>();
            var candidatosExistentesBloqueMedia = new List<CandidatoPersona>();
            var candidatosExistentesBloqueBaja = new List<CandidatoPersona>();
            var estadosDistritos = new List<DistritosFederales>();

            if (representanteId == 2)
            {
                distritosCompetenciaBaja = ObtenerDistritosIndigenasPorCompetitividad("BAJA");
                distritosCompetenciaMedia = ObtenerDistritosIndigenasPorCompetitividad("MEDIA");
                distritosCompetenciaAlta = ObtenerDistritosIndigenasPorCompetitividad("ALTA");

                estadosDistritos = distritosCompetenciaBaja
                    .Concat(distritosCompetenciaMedia)
                    .Concat(distritosCompetenciaAlta)
                    .ToList();

            }

            var resultadosExistentes = _context.CandidatoPersona
                .Where(cp => cp.CandidatosChc.EsAccionesAfirmativas == true &&
                        cp.CandidatosChc.Activo == true &&
                        cp.CandidatosChc.RepresentanteId == representanteId && 
                        cp.CandidatosChc.CircunscripcionId == circunscripcionId
                        )
                .GroupBy(cp => cp.CandidatosChc.EstadoId)
                .Select(group => new
                {
                    EntidadId = group.Key,
                    CantidadMujeres = group.Count(cp => cp.Persona.GeneroId == 1),
                    CantidadIndigenas = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true),
                    CantidadIndigenasMujeresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true &&
                                                    cp.Persona.GeneroId == 1),
                    CantidadIndigenasHombresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true &&
                                                    cp.Persona.GeneroId == 2),
                    CantidadAfromexicanos = group.Count(cp => cp.CandidatosChc.Afromexicanas == true),
                    CantidadDiscapacidad = group.Count(cp => cp.CandidatosChc.ConDiscapacidad == true),
                    CantidadMigrantes = group.Count(cp => cp.CandidatosChc.MexicanosMigrantes == true),
                    CantidadDiversidadSexual = group.Count(cp => cp.CandidatosChc.DiversidadSexual == true),
                    CantidadHombres = group.Count(cp => cp.Persona.GeneroId == 2)
                }).ToList();

            var resultadoPorEstado = estados
                .Select(catalogo => new AnalisisEstado
                {
                    EntidadId = catalogo.Id,
                    NombreEstado = catalogo.Nombre,
                    // Obtener los resultados existentes o establecer a 0 si no existen
                    CantidadMujeres = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadMujeres ?? 0,
                    CantidadIndigenas = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenas ?? 0,
                    CantidadAfromexicanos = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadAfromexicanos ?? 0,
                    CantidadDiscapacidad = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadDiscapacidad ?? 0,
                    CantidadMigrantes = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadMigrantes ?? 0,
                    CantidadDiversidadSexual = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadDiversidadSexual ?? 0,
                    CantidadHombres = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadHombres ?? 0,
                    CantidadIndigenasMujeresRegistrados = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenasMujeresRegistrados ?? 0,
                    CantidadIndigenasHombresRegistrados = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenasHombresRegistrados ?? 0,
                    LugaresTotales = _context.DetalleRequisitoDiputaciones.Where(rpc => rpc.EstadoCircunscripcion.EntidadId == catalogo.Id)
                    .Select(rpc => representanteId == 1
                            ? rpc.CandidatosDiputadosRepresentacionProporcional
                            : representanteId == 2
                                ? rpc.CandidatosDiputadosMayoriaRelativa
                                : representanteId == 3
                                    ? rpc.CandidatosSenadorRepresentacionProporcional
                                    : representanteId == 4
                                        ? rpc.CandidatosSenadorMayoriaRelativa : 0
                    )
                    .FirstOrDefault(),
                    RequisitoMujeres = _context.DetalleRequisitoDiputaciones.Where(rpc => rpc.EstadoCircunscripcion.EntidadId == catalogo.Id)
                    .Select(rpc => representanteId == 1
                            ? rpc.MujeresDiputadosRepresentacionProporcional
                            : representanteId == 2
                                ? rpc.MujeresDiputadosMayoriaRelativa
                                    : representanteId == 4
                                        ? rpc.MujeresSenadorMayoriaRelativa : 0
                    )
                    .FirstOrDefault(),
                    
                    RequisitoIndigena = representanteId==2?estadosDistritos.Count(j => j.EntidadId == catalogo.Id):0,
                    RequisitoHombres = _context.DetalleRequisitoDiputaciones
                    .Where(rpc => rpc.EstadoCircunscripcion.EntidadId == catalogo.Id)
                    .Select(rpc => 
                        (representanteId == 1 ? rpc.CandidatosDiputadosRepresentacionProporcional :
                        representanteId == 2 ? rpc.CandidatosDiputadosMayoriaRelativa : 0) - (
                        representanteId == 1 ? rpc.MujeresDiputadosRepresentacionProporcional :
                        representanteId == 2 ? rpc.MujeresDiputadosMayoriaRelativa:0)
                    ).FirstOrDefault()

                }).ToList();

            var resultado = new {
                estados,
                resultadoPorEstado,
                distritosCompetenciaBaja,
                distritosCompetenciaMedia,
                distritosCompetenciaAlta,
                candidatosExistentesBloqueBaja,
                candidatosExistentesBloqueMedia,
                candidatosExistentesBloqueAlta,
                estadosDistritos,
                catalogoRepresentante
            };

            var response = new ApiResponse<object>
            {
                Success = true,
                StatusCode = 200,
                Data = resultado
            };

            return Ok(response);
        }

        // GET api/<DetalleRequisitosDiputacionesController>/5
        [HttpGet("ObtenerDetalleSenadoresRp")]
        public async Task<IActionResult> ObtenerDetalleSenadoresRp()
        {
            //obtener Catalogo Representate
            var catalogoRepresentante = await _context.CatalogoRepresentante
                .Where(drd => drd.Id == 3)
                .FirstOrDefaultAsync();

            //obtenemosCircunscripcion
            var estados = _context.EntidadFederativa.ToList();

            //Obtenemos los requisitos
            var detalleRequisito = await _context.DetalleRequisitoDiputaciones
                .Include(d => d.EstadoCircunscripcion)
                .ToListAsync();

            //DatosEsperadosGenerales
            var datosEsperadosGeneral = await _context.DatosEsperadosPorTipoCandidatura
                .Where(detc => detc.CatalogoRepresentanteId == 3 && detc.Activo == true)
                .OrderByDescending(detc => detc.AnioElecciones)
                .FirstOrDefaultAsync();

            var candidatosEsperadosPorCircunscripcion = _context.DetalleRequisitoDiputaciones
                .GroupBy(drd => drd.EstadoCircunscripcion.EntidadId)
                .Select(
                    group => new
                    {
                        EntidadId = group.Key,
                        SumaCandidatos = group.Sum(drd => drd.CandidatosSenadorRepresentacionProporcional)
                    }
                ).ToList();

            var categorias = new List<string>
            {
                "PersonasIndigenas",
                "PersonasAfromexicanas",
                "DiversidadSexual",
                "Discapacidad",
                "Migrantes",
                "Mujeres"
            };

            var resultadosPorCategoria = categorias.Select(categoria =>
            {
                var candidatosPorCategoria = ObtenerCandidatosPorCategoriaEstado(3, categoria, true, estados);
                return new
                {
                    Categoria = categoria,
                    CandidatosPorCategoria = candidatosPorCategoria
                };
            }).ToList();

            /*INDIGENAS*/
            var indigenas = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasIndigenas")?.CandidatosPorCategoria;

            int totalCandidatosIndigenas = indigenas?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresIndigenas = indigenas != null
                ? indigenas.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresIndigenas = indigenas != null
                ? indigenas.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoIndigenas = datosEsperadosGeneral.CantidadAdscripcionIndigena;

            bool cumpleParidadIndigena = cantidadMujeresIndigenas >= cantidadHombresIndigenas;

            bool cumpleRequisitoRegistroIndigena = totalCandidatosIndigenas >= requisitoIndigenas;

            var analisisIndigena = new
            {
                indigenas,
                totalCandidatosIndigenas,
                cantidadMujeresIndigenas,
                cantidadHombresIndigenas,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoIndigenas,
                cumpleParidadIndigena,
                cumpleRequisitoRegistroIndigena,
            };

            /*FIN INDIGENAS*/

            /*DISCAPACIDAD*/
            var discapacidad = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Discapacidad")?.CandidatosPorCategoria;

            int totalCandidatosDiscapacidad = discapacidad?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiscapacidad = discapacidad != null
                ? discapacidad.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresDiscapacidad = discapacidad != null
                ? discapacidad.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoDiscapacidad = datosEsperadosGeneral.CantidadDiscapacitados;

            bool cumpleParidadDiscapacidad = cantidadMujeresDiscapacidad >= cantidadHombresDiscapacidad;

            bool cumpleRequisitoRegistroDiscapacitado = totalCandidatosDiscapacidad >= requisitoDiscapacidad;

            var analisisDiscapacitado = new
            {
                discapacidad,
                totalCandidatosDiscapacidad,
                cantidadMujeresDiscapacidad,
                cantidadHombresDiscapacidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoDiscapacidad,
                cumpleParidadDiscapacidad,
                cumpleRequisitoRegistroDiscapacitado,
            };

            /*FIN DISCAPACIDAD*/

            /*DIVERSIDAD SEXUAL*/
            var diversidadSexual = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "DiversidadSexual")?.CandidatosPorCategoria;

            int totalCandidatosDiversidad = diversidadSexual?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiversidad = diversidadSexual != null
                ? diversidadSexual.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresDiversidad = diversidadSexual != null
                ? diversidadSexual.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoDiversidad = datosEsperadosGeneral.CantidadDiversidadSexual;

            bool cumpleParidadDiversidad = cantidadMujeresDiversidad >= cantidadHombresDiversidad;

            bool cumpleRequisitoRegistroDiversidad = totalCandidatosDiversidad >= requisitoDiversidad;

            var analisisDiversidad = new
            {
                diversidadSexual,
                totalCandidatosDiversidad,
                cantidadMujeresDiversidad,
                cantidadHombresDiversidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoDiversidad,
                cumpleParidadDiversidad,
                cumpleRequisitoRegistroDiversidad,
            };

            /**FIN DIVERSIDAD SEXUAL*/

            /*ANALISIS MIGRANTES*/
            var migrantes = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Migrantes")?.CandidatosPorCategoria;

            int totalCandidatosMigrantes = migrantes?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresMigrantes = migrantes != null
                ? migrantes.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresMigrantes = migrantes != null
                ? migrantes.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoMigrantes = datosEsperadosGeneral.CantidadPersonaMigrante;

            int mujeresNecesarios = (requisitoMigrantes + 1) / 2;

            int hombresNecesarios = (requisitoMigrantes / 2);

            bool cumpleParidadMigrante = (cantidadMujeresMigrantes >= mujeresNecesarios)
                && (cantidadHombresMigrantes >= hombresNecesarios)
                && (cantidadMujeresMigrantes >= cantidadHombresMigrantes);

            bool cumpleRequisitoRegistroMigrante = cantidadMujeresMigrantes + cantidadHombresMigrantes >= requisitoMigrantes;

            var analisisMigrantes = new
            {
                migrantes,
                totalCandidatosMigrantes,
                cantidadMujeresMigrantes,
                cantidadHombresMigrantes,
                mujeresNecesarios,
                hombresNecesarios,
                requisitoMigrantes,
                cumpleParidadMigrante,
                cumpleRequisitoRegistroMigrante,
            };

            /*FIN ANALISIS MIGRANTE*/

            var mujeresRP = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Mujeres")?.CandidatosPorCategoria;

            /*INICIO ANALISIS AFROMEXICANOS*/
            var personasAfromexicanas = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasAfromexicanas")?.CandidatosPorCategoria;

            int totalCandidatosAfromexicanas = personasAfromexicanas?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresAfromexicanas = personasAfromexicanas != null
                ? personasAfromexicanas.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.Afromexicanas == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresAfromexicanas = personasAfromexicanas != null
                ? personasAfromexicanas.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.Afromexicanas == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoAfromexicana = datosEsperadosGeneral.CantidadAfromexicanos;

            bool cumpleParidadAfromexicana = cantidadMujeresMigrantes >= cantidadHombresAfromexicanas;

            bool cumpleRequisitoRegistroAfromexicana = totalCandidatosAfromexicanas >= requisitoAfromexicana;

            var analisisAfromexicanas = new
            {
                personasAfromexicanas,
                totalCandidatosAfromexicanas,
                cantidadMujeresAfromexicanas,
                cantidadHombresAfromexicanas,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoAfromexicana,
                cumpleParidadAfromexicana,
                cumpleRequisitoRegistroAfromexicana
            };

            /*ANALISIS AFROMEXICANOS*/


            var personasIndigenasRP = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasIndigenas")?.CandidatosPorCategoria;


            var resultadosExistentes = _context.CandidatoPersona
                .Where(cp => cp.CandidatosChc.EsAccionesAfirmativas == true &&
                        cp.CandidatosChc.Activo == true &&
                        cp.CandidatosChc.RepresentanteId == 3
                        )
                .GroupBy(cp => cp.CandidatosChc.EstadoId)
                .Select(group => new
                {
                    EntidadId = group.Key,
                    CantidadMujeres = group.Count(cp => cp.Persona.GeneroId == 1),
                    CantidadIndigenas = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true),
                    CantidadIndigenasMujeresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true &&
                                                    cp.Persona.GeneroId == 1),
                    CantidadIndigenasHombresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true &&
                                                    cp.Persona.GeneroId == 2),
                    CantidadAfromexicanos = group.Count(cp => cp.CandidatosChc.Afromexicanas == true),
                    CantidadDiscapacidad = group.Count(cp => cp.CandidatosChc.ConDiscapacidad == true),
                    CantidadMigrantes = group.Count(cp => cp.CandidatosChc.MexicanosMigrantes == true),
                    CantidadDiversidadSexual = group.Count(cp => cp.CandidatosChc.DiversidadSexual == true),
                    CantidadHombres = group.Count(cp => cp.Persona.GeneroId == 2)
                }).ToList();

            var resultadoPorEstado = estados
                .Select(catalogo => new AnalisisEstado
                {
                    EntidadId = catalogo.Id,
                    NombreEstado = catalogo.Nombre,
                    // Obtener los resultados existentes o establecer a 0 si no existen
                    CantidadMujeres = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadMujeres ?? 0,
                    CantidadIndigenas = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenas ?? 0,
                    CantidadAfromexicanos = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadAfromexicanos ?? 0,
                    CantidadDiscapacidad = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadDiscapacidad ?? 0,
                    CantidadMigrantes = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadMigrantes ?? 0,
                    CantidadDiversidadSexual = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadDiversidadSexual ?? 0,
                    CantidadHombres = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadHombres ?? 0,
                    CantidadIndigenasMujeresRegistrados = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenasMujeresRegistrados ?? 0,
                    CantidadIndigenasHombresRegistrados = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenasHombresRegistrados ?? 0,
                    LugaresTotales = _context.DetalleRequisitoDiputaciones.Where(rpc => rpc.EstadoCircunscripcion.EntidadId == catalogo.Id).Select(rpc => rpc.CandidatosSenadorRepresentacionProporcional).FirstOrDefault(),
                }).ToList();


            var resumen = new
            {
                catalogoRepresentante,
                estados,
                resultadosPorCategoria,
                //datosEsperadosGeneral,
                //cantidadRequisitoIndigena,
                //candidatosEsperadosPorCircunscripcion,
                //candidatosPorCircuscripcion,
                //discapacidad,
                //diversidadSexual,
                //migrantes,
                //mujeresRP,
                //personasAfromexicanas,
                //personasIndigenasRP,
                resultadoPorEstado,
                analisisDiscapacitado,
                analisisDiversidad,
                analisisMigrantes,
                analisisAfromexicanas,
                analisisIndigena,
            };

            return Ok(resumen);

        }


        // GET api/<DetalleRequisitosDiputacionesController>/5
        [HttpGet("ObtenerDetalleSenadoresMr")]
        public async Task<IActionResult> ObtenerDetalleSenadoresMr()
        {
            //obtener Catalogo Representate
            var catalogoRepresentante = await _context.CatalogoRepresentante
                .Where(drd => drd.Id == 4)
                .FirstOrDefaultAsync();

            //obtenemosCircunscripcion
            var estados = _context.EntidadFederativa.ToList();

            //Obtenemos los requisitos
            var detalleRequisito = await _context.DetalleRequisitoDiputaciones
                .Include(d => d.EstadoCircunscripcion)
                .ToListAsync();

            //DatosEsperadosGenerales
            var datosEsperadosGeneral = await _context.DatosEsperadosPorTipoCandidatura
                .Where(detc => detc.CatalogoRepresentanteId == 4 && detc.Activo == true)
                .OrderByDescending(detc => detc.AnioElecciones)
                .FirstOrDefaultAsync();

            var requisitosPorCircunscripcion = await _context.RequisitoPorCircunscripcion
                .Where(rpc => rpc.RepresentanteId == 4 && rpc.AnioEleccion == 2024)
                .FirstOrDefaultAsync();

            var candidatosEsperadosPorCircunscripcion = _context.DetalleRequisitoDiputaciones
                .GroupBy(drd => drd.EstadoCircunscripcion.EntidadId)
                .Select(
                    group => new
                    {
                        EntidadId = group.Key,
                        SumaCandidatos = group.Sum(drd => drd.CandidatosSenadorMayoriaRelativa)
                    }
                ).ToList();

            var categorias = new List<string>
            {
                "PersonasIndigenas",
                "PersonasAfromexicanas",
                "DiversidadSexual",
                "Discapacidad",
                "Migrantes",
                "Mujeres"
            };

            var resultadosPorCategoria = categorias.Select(categoria =>
            {
                var candidatosPorCategoria = ObtenerCandidatosPorCategoriaEstado(4, categoria, true, estados);
                return new
                {
                    Categoria = categoria,
                    CandidatosPorCategoria = candidatosPorCategoria
                };
            }).ToList();

            /*INDIGENAS*/
            var indigenas = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasIndigenas")?.CandidatosPorCategoria;

            int totalCandidatosIndigenas = indigenas?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresIndigenas = indigenas != null
                ? indigenas.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresIndigenas = indigenas != null
                ? indigenas.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoIndigenas = datosEsperadosGeneral.CantidadAdscripcionIndigena;

            bool cumpleParidadIndigena = cantidadMujeresIndigenas >= cantidadHombresIndigenas;

            bool cumpleRequisitoRegistroIndigena = totalCandidatosIndigenas >= requisitoIndigenas;

            var analisisIndigena = new
            {
                indigenas,
                totalCandidatosIndigenas,
                cantidadMujeresIndigenas,
                cantidadHombresIndigenas,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoIndigenas,
                cumpleParidadIndigena,
                cumpleRequisitoRegistroIndigena,
            };

            /*FIN INDIGENAS*/

            /*DISCAPACIDAD*/
            var discapacidad = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Discapacidad")?.CandidatosPorCategoria;

            int totalCandidatosDiscapacidad = discapacidad?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiscapacidad = discapacidad != null
                ? discapacidad.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresDiscapacidad = discapacidad != null
                ? discapacidad.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoDiscapacidad = datosEsperadosGeneral.CantidadDiscapacitados;

            bool cumpleParidadDiscapacidad = cantidadMujeresDiscapacidad >= cantidadHombresDiscapacidad;

            bool cumpleRequisitoRegistroDiscapacitado = totalCandidatosDiscapacidad >= requisitoDiscapacidad;

            var analisisDiscapacitado = new
            {
                discapacidad,
                totalCandidatosDiscapacidad,
                cantidadMujeresDiscapacidad,
                cantidadHombresDiscapacidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoDiscapacidad,
                cumpleParidadDiscapacidad,
                cumpleRequisitoRegistroDiscapacitado,
            };

            /*FIN DISCAPACIDAD*/

            /*DIVERSIDAD SEXUAL*/
            var diversidadSexual = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "DiversidadSexual")?.CandidatosPorCategoria;

            int totalCandidatosDiversidad = diversidadSexual?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiversidad = diversidadSexual != null
                ? diversidadSexual.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresDiversidad = diversidadSexual != null
                ? diversidadSexual.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoDiversidad = datosEsperadosGeneral.CantidadDiversidadSexual;

            bool cumpleParidadDiversidad = cantidadMujeresDiversidad >= cantidadHombresDiversidad;

            bool cumpleRequisitoRegistroDiversidad = totalCandidatosDiversidad >= requisitoDiversidad;

            var analisisDiversidad = new
            {
                diversidadSexual,
                totalCandidatosDiversidad,
                cantidadMujeresDiversidad,
                cantidadHombresDiversidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoDiversidad,
                cumpleParidadDiversidad,
                cumpleRequisitoRegistroDiversidad,
            };

            /**FIN DIVERSIDAD SEXUAL*/

            /*ANALISIS MIGRANTES*/
            var migrantes = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Migrantes")?.CandidatosPorCategoria;

            int totalCandidatosMigrantes = migrantes?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresMigrantes = migrantes != null
                ? migrantes.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresMigrantes = migrantes != null
                ? migrantes.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoMigrantes = datosEsperadosGeneral.CantidadPersonaMigrante;

            int mujeresNecesarios = (requisitoMigrantes + 1) / 2;

            int hombresNecesarios = (requisitoMigrantes / 2);

            bool cumpleParidadMigrante = (cantidadMujeresMigrantes >= mujeresNecesarios)
                && (cantidadHombresMigrantes >= hombresNecesarios)
                && (cantidadMujeresMigrantes >= cantidadHombresMigrantes);

            bool cumpleRequisitoRegistroMigrante = cantidadMujeresMigrantes + cantidadHombresMigrantes >= requisitoMigrantes;

            var analisisMigrantes = new
            {
                migrantes,
                totalCandidatosMigrantes,
                cantidadMujeresMigrantes,
                cantidadHombresMigrantes,
                mujeresNecesarios,
                hombresNecesarios,
                requisitoMigrantes,
                cumpleParidadMigrante,
                cumpleRequisitoRegistroMigrante,
            };

            /*FIN ANALISIS MIGRANTE*/

            var mujeresRP = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Mujeres")?.CandidatosPorCategoria;

            /*INICIO ANALISIS AFROMEXICANOS*/
            var personasAfromexicanas = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasAfromexicanas")?.CandidatosPorCategoria;

            int totalCandidatosAfromexicanas = personasAfromexicanas?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresAfromexicanas = personasAfromexicanas != null
                ? personasAfromexicanas.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.Afromexicanas == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresAfromexicanas = personasAfromexicanas != null
                ? personasAfromexicanas.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.Afromexicanas == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoAfromexicana = datosEsperadosGeneral.CantidadAfromexicanos;

            bool cumpleParidadAfromexicana = cantidadMujeresMigrantes >= cantidadHombresAfromexicanas;

            bool cumpleRequisitoRegistroAfromexicana = totalCandidatosAfromexicanas >= requisitoAfromexicana;

            var analisisAfromexicanas = new
            {
                personasAfromexicanas,
                totalCandidatosAfromexicanas,
                cantidadMujeresAfromexicanas,
                cantidadHombresAfromexicanas,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoAfromexicana,
                cumpleParidadAfromexicana,
                cumpleRequisitoRegistroAfromexicana
            };

            /*ANALISIS AFROMEXICANOS*/


            var personasIndigenasRP = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasIndigenas")?.CandidatosPorCategoria;


            var resultadosExistentes = _context.CandidatoPersona
                .Where(cp => cp.CandidatosChc.EsAccionesAfirmativas == true &&
                        cp.CandidatosChc.Activo == true &&
                        cp.CandidatosChc.RepresentanteId == 4
                        )
                .GroupBy(cp => cp.CandidatosChc.EstadoId)
                .Select(group => new
                {
                    EntidadId = group.Key,
                    CantidadMujeres = group.Count(cp => cp.Persona.GeneroId == 1),
                    CantidadIndigenas = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true),
                    CantidadIndigenasMujeresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true &&
                                                    cp.Persona.GeneroId == 1),
                    CantidadIndigenasHombresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true &&
                                                    cp.Persona.GeneroId == 2),
                    CantidadAfromexicanos = group.Count(cp => cp.CandidatosChc.Afromexicanas == true),
                    CantidadDiscapacidad = group.Count(cp => cp.CandidatosChc.ConDiscapacidad == true),
                    CantidadMigrantes = group.Count(cp => cp.CandidatosChc.MexicanosMigrantes == true),
                    CantidadDiversidadSexual = group.Count(cp => cp.CandidatosChc.DiversidadSexual == true),
                    CantidadHombres = group.Count(cp => cp.Persona.GeneroId == 2)
                }).ToList();

            var resultadoPorEstado = estados
                .Select(catalogo => new AnalisisEstado
                {
                    EntidadId = catalogo.Id,
                    NombreEstado = catalogo.Nombre,
                    // Obtener los resultados existentes o establecer a 0 si no existen
                    CantidadMujeres = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadMujeres ?? 0,
                    CantidadIndigenas = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenas ?? 0,
                    CantidadAfromexicanos = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadAfromexicanos ?? 0,
                    CantidadDiscapacidad = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadDiscapacidad ?? 0,
                    CantidadMigrantes = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadMigrantes ?? 0,
                    CantidadDiversidadSexual = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadDiversidadSexual ?? 0,
                    CantidadHombres = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadHombres ?? 0,
                    CantidadIndigenasMujeresRegistrados = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenasMujeresRegistrados ?? 0,
                    CantidadIndigenasHombresRegistrados = resultadosExistentes.FirstOrDefault(r => r.EntidadId == catalogo.Id)?.CantidadIndigenasHombresRegistrados ?? 0,
                    LugaresTotales = _context.DetalleRequisitoDiputaciones.Where(rpc => rpc.EstadoCircunscripcion.EntidadId == catalogo.Id).Select(rpc => rpc.CandidatosSenadorMayoriaRelativa).FirstOrDefault(),
                    RequisitoMujeres = _context.DetalleRequisitoDiputaciones.Where(rpc => rpc.EstadoCircunscripcion.EntidadId == catalogo.Id).Select(rpc => rpc.MujeresSenadorMayoriaRelativa).FirstOrDefault(), 
                    RequisitoHombres = _context.DetalleRequisitoDiputaciones.Where(rpc => rpc.EstadoCircunscripcion.EntidadId == catalogo.Id).Select(rpc => rpc.CandidatosSenadorMayoriaRelativa -rpc.MujeresSenadorMayoriaRelativa).FirstOrDefault(),
                }).ToList();


            var resumen = new
            {
                catalogoRepresentante,
                estados,
                resultadosPorCategoria,
                //datosEsperadosGeneral,
                //cantidadRequisitoIndigena,
                //candidatosEsperadosPorCircunscripcion,
                //candidatosPorCircuscripcion,
                //discapacidad,
                //diversidadSexual,
                //migrantes,
                //mujeresRP,
                //personasAfromexicanas,
                //personasIndigenasRP,
                resultadoPorEstado,
                analisisDiscapacitado,
                analisisDiversidad,
                analisisMigrantes,
                analisisAfromexicanas,
                analisisIndigena,
            };

            return Ok(resumen);

        }

        public class AnalisisEstado
        {
            public int EntidadId { get; set; }

            public string NombreEstado { get; set; }

            public int CantidadMujeres { get; set; }

            public int CantidadIndigenas { get; set; }

            public int CantidadAfromexicanos { get; set; }

            public int CantidadDiscapacidad { get; set; }

            public int CantidadMigrantes { get; set; }

            public int CantidadDiversidadSexual { get; set; }

            public int CantidadHombres { get; set; }

            public int LugaresTotales { get; set; }

            public int PersonasIndigenas { get; set; }

            public int CantidadIndigenasMujeresRegistrados { get; set; }

            public int CantidadIndigenasHombresRegistrados { get; set; }

            public int RequisitoIndigena { get; set; }

            public List<string> Distritos { get; set; }

            public int RequisitoMigrante { get; set; }

            public int RequisitoMujeres { get; set; }

            public int RequisitoHombres { get; set; }
        }

        [HttpGet("ObtenerDetalleDiputadosRP")]
        public async Task<IActionResult> GetObtenerDetalleDiputadosRP()
        {
            //obtener Catalogo Representate
            var catalogoRepresentante = await _context.CatalogoRepresentante
                .Where(drd => drd.Id == 1)
                .FirstOrDefaultAsync();
            
            //obtenemosCircunscripcion
            var circunscripcion = _context.CatalogoCircunscripcion.ToList();

            //Obtenemos los requisitos
            var detalleRequisito = await _context.DetalleRequisitoDiputaciones
                .Include(d => d.EstadoCircunscripcion)
                .ToListAsync();

            //DatosEsperadosGenerales
            var datosEsperadosGeneral = await _context.DatosEsperadosPorTipoCandidatura
                .Where(detc => detc.CatalogoRepresentanteId == 1 && detc.Activo == true)
                .OrderByDescending(detc => detc.AnioElecciones)
                .FirstOrDefaultAsync();

            var requisitosPorCircunscripcion = await _context.RequisitoPorCircunscripcion
                .Where(rpc => rpc.RepresentanteId == 1 && rpc.AnioEleccion == 2024)
                .FirstOrDefaultAsync();

            var cantidadRequisitoIndigena = Convert.ToInt32(datosEsperadosGeneral.CantidadAdscripcionIndigena);

            var candidatosEsperadosPorCircunscripcion = _context.DetalleRequisitoDiputaciones
                .GroupBy(drd => drd.EstadoCircunscripcion.CircunscripcionId)
                .Select(
                    group => new
                    {
                        CircunscripcionID = group.Key,
                        SumaCandidatos = group.Sum(drd => drd.CandidatosDiputadosRepresentacionProporcional)
                    }
                ).ToList();

            int candidatosPorCircuscripcion = 40;

            var categorias = new List<string>
            {
                "PersonasIndigenas",
                "PersonasAfromexicanas",
                "DiversidadSexual",
                "Discapacidad",
                "Migrantes",
                "Mujeres"
            };

            var resultadosPorCategoria = categorias.Select(categoria =>
            {
                var candidatosPorCategoria = ObtenerCandidatosPorCategoria(1, categoria, true, circunscripcion);
                return new
                {
                    Categoria = categoria,
                    CandidatosPorCategoria = candidatosPorCategoria
                };
            }).ToList();

            /*INDIGENAS*/
            var indigenas = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasIndigenas")?.CandidatosPorCategoria;

            int totalCandidatosIndigenas = indigenas?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresIndigenas = indigenas != null
                ? indigenas.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresIndigenas = indigenas != null
                ? indigenas.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoIndigenas = datosEsperadosGeneral.CantidadAdscripcionIndigena;

            bool cumpleParidadIndigena = cantidadMujeresIndigenas >= cantidadHombresIndigenas;

            bool cumpleRequisitoRegistroIndigena = totalCandidatosIndigenas >= requisitoIndigenas;

            var analisisIndigena = new
            {
                indigenas,
                totalCandidatosIndigenas,
                cantidadMujeresIndigenas,
                cantidadHombresIndigenas,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoIndigenas,
                cumpleParidadIndigena,
                cumpleRequisitoRegistroIndigena,
            };

            /*FIN INDIGENAS*/

            /*DISCAPACIDAD*/
            var discapacidad = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Discapacidad")?.CandidatosPorCategoria;

            int totalCandidatosDiscapacidad = discapacidad?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiscapacidad = discapacidad != null
                ? discapacidad.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresDiscapacidad = discapacidad != null
                ? discapacidad.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoDiscapacidad = datosEsperadosGeneral.CantidadDiscapacitados;

            bool cumpleParidadDiscapacidad = cantidadMujeresDiscapacidad >= cantidadHombresDiscapacidad;

            bool cumpleRequisitoRegistroDiscapacitado = totalCandidatosDiscapacidad >= requisitoDiscapacidad;

            var analisisDiscapacitado = new
            {
                discapacidad,
                totalCandidatosDiscapacidad,
                cantidadMujeresDiscapacidad,
                cantidadHombresDiscapacidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoDiscapacidad,
                cumpleParidadDiscapacidad,
                cumpleRequisitoRegistroDiscapacitado,
            };

            /*FIN DISCAPACIDAD*/

            /*DIVERSIDAD SEXUAL*/
            var diversidadSexual = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "DiversidadSexual")?.CandidatosPorCategoria;

            int totalCandidatosDiversidad = diversidadSexual?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiversidad = diversidadSexual != null
                ? diversidadSexual.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresDiversidad = diversidadSexual != null
                ? diversidadSexual.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoDiversidad = datosEsperadosGeneral.CantidadDiversidadSexual;

            bool cumpleParidadDiversidad = cantidadMujeresDiversidad >= cantidadHombresDiversidad;

            bool cumpleRequisitoRegistroDiversidad = totalCandidatosDiversidad >= requisitoDiversidad;

            var analisisDiversidad = new
            {
                diversidadSexual,
                totalCandidatosDiversidad,
                cantidadMujeresDiversidad,
                cantidadHombresDiversidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoDiversidad,
                cumpleParidadDiversidad,
                cumpleRequisitoRegistroDiversidad,
            };

            /**FIN DIVERSIDAD SEXUAL*/
            
            /*ANALISIS MIGRANTES*/
            var migrantes = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Migrantes")?.CandidatosPorCategoria;

            int totalCandidatosMigrantes = migrantes?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresMigrantes = migrantes != null
                ? migrantes.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresMigrantes = migrantes != null
                ? migrantes.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoMigrantes = datosEsperadosGeneral.CantidadPersonaMigrante;

            int mujeresNecesarios = (requisitoMigrantes + 1) / 2;

            int hombresNecesarios = (requisitoMigrantes / 2);

            bool cumpleParidadMigrante = (cantidadMujeresMigrantes >= mujeresNecesarios) 
                && (cantidadHombresMigrantes >= hombresNecesarios)
                && (cantidadMujeresMigrantes >= cantidadHombresMigrantes);

            bool cumpleRequisitoRegistroMigrante = cantidadMujeresMigrantes + cantidadHombresMigrantes >= requisitoMigrantes;

            var analisisMigrantes = new
            {
                migrantes,
                totalCandidatosMigrantes,
                cantidadMujeresMigrantes,
                cantidadHombresMigrantes,
                mujeresNecesarios,
                hombresNecesarios,
                requisitoMigrantes,
                cumpleParidadMigrante,
                cumpleRequisitoRegistroMigrante,
            };

            /*FIN ANALISIS MIGRANTE*/

            var mujeresRP = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Mujeres")?.CandidatosPorCategoria;

            /*INICIO ANALISIS AFROMEXICANOS*/
            var personasAfromexicanas = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasAfromexicanas")?.CandidatosPorCategoria;
            
            int totalCandidatosAfromexicanas = personasAfromexicanas?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresAfromexicanas = personasAfromexicanas != null
                ? personasAfromexicanas.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.Afromexicanas == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresAfromexicanas = personasAfromexicanas != null
                ? personasAfromexicanas.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.Afromexicanas == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoAfromexicana = datosEsperadosGeneral.CantidadAfromexicanos;

            bool cumpleParidadAfromexicana = cantidadMujeresMigrantes >= cantidadHombresAfromexicanas;

            bool cumpleRequisitoRegistroAfromexicana = totalCandidatosAfromexicanas >= requisitoAfromexicana;

            var analisisAfromexicanas = new
            {
                personasAfromexicanas,
                totalCandidatosAfromexicanas,
                cantidadMujeresAfromexicanas,
                cantidadHombresAfromexicanas,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoAfromexicana,
                cumpleParidadAfromexicana,
                cumpleRequisitoRegistroAfromexicana
            };

            /*ANALISIS AFROMEXICANOS*/


            var personasIndigenasRP = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasIndigenas")?.CandidatosPorCategoria;


            var resultadosExistentes = _context.CandidatoPersona
                .Where(cp => cp.CandidatosChc.EsAccionesAfirmativas == true &&
                        cp.CandidatosChc.Activo == true &&
                        cp.CandidatosChc.RepresentanteId == 1
                        )
                .GroupBy(cp => cp.CandidatosChc.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    CantidadMujeres = group.Count(cp => cp.Persona.GeneroId == 1),
                    CantidadIndigenas = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true),
                    CantidadIndigenasMujeresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true && 
                                                    cp.Persona.GeneroId == 1),
                    CantidadIndigenasHombresRegistrados = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true &&
                                                    cp.Persona.GeneroId == 2),
                    CantidadAfromexicanos = group.Count(cp => cp.CandidatosChc.Afromexicanas == true),
                    CantidadDiscapacidad = group.Count(cp => cp.CandidatosChc.ConDiscapacidad == true),
                    CantidadMigrantes = group.Count(cp => cp.CandidatosChc.MexicanosMigrantes == true),
                    CantidadDiversidadSexual = group.Count(cp => cp.CandidatosChc.DiversidadSexual == true),
                    CantidadHombres = group.Count(cp => cp.Persona.GeneroId == 2)
                }).ToList();

            var resultadoPorCircunscripcion = circunscripcion
                .Select(catalogo => new AnalisisCircuncripcion
                {
                    CircunscripcionId = catalogo.Id,
                    ShortId = catalogo.ShortId,
                    NombreCircunscripcion = catalogo.Nombre,
                    // Obtener los resultados existentes o establecer a 0 si no existen
                    CantidadMujeres = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadMujeres ?? 0,
                    CantidadIndigenas = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadIndigenas ?? 0,
                    CantidadAfromexicanos = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadAfromexicanos ?? 0,
                    CantidadDiscapacidad = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadDiscapacidad ?? 0,
                    CantidadMigrantes = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadMigrantes ?? 0,
                    CantidadDiversidadSexual = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadDiversidadSexual ?? 0,
                    CantidadHombres = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadHombres ?? 0,
                    CantidadIndigenasMujeresRegistrados = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadIndigenasMujeresRegistrados??0,
                    CantidadIndigenasHombresRegistrados = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadIndigenasHombresRegistrados ?? 0,
                    LugaresTotales = _context.RequisitoPorCircunscripcion.Where(rpc => rpc.CicunscripcionId == catalogo.Id).Select(rpc => rpc.LugaresDisponibles).FirstOrDefault(),
                    PersonasIndigenas = _context.RequisitoPorCircunscripcion.Where(rpc => rpc.CicunscripcionId == catalogo.Id ).Select(rpc => rpc.CantidadIdentificacionIndigena).FirstOrDefault(),
                    Estados = _context.EstadoCircunscripcion.Where(ec => ec.CircunscripcionId == catalogo.Id).Select(ec => ec.EntidadFederativa.Nombre).ToList(),
                    RequisitoIndigena = _context.RequisitoPorCircunscripcion.Where(rpc => rpc.CicunscripcionId == catalogo.Id).Select(ec => ec.CantidadIdentificacionIndigena).FirstOrDefault(),
                    RequisitoMigrante = _context.RequisitoPorCircunscripcion.Where(rpc => rpc.CicunscripcionId == catalogo.Id).Select(ec => ec.CantidadMigrantes).FirstOrDefault(),
                    RequisitoMujeres = _context.RequisitoPorCircunscripcion.Where(rpc => rpc.CicunscripcionId == catalogo.Id).Select(ec => ec.CantidadMujeres).FirstOrDefault()
                }).ToList();


            var resumen = new {
                catalogoRepresentante,
                circunscripcion,
                datosEsperadosGeneral,
                cantidadRequisitoIndigena,
                candidatosEsperadosPorCircunscripcion,
                candidatosPorCircuscripcion,
                discapacidad,
                diversidadSexual,
                migrantes,
                mujeresRP,
                personasAfromexicanas,
                personasIndigenasRP,
                resultadoPorCircunscripcion,
                analisisDiscapacitado,
                analisisDiversidad,
                analisisMigrantes,
                analisisAfromexicanas,
                analisisIndigena,
            };

            return Ok(resumen);

        }

        public class AnalisisCircuncripcion
        {
            public int CircunscripcionId { get; set; }

            public string ShortId { get; set; }

            public string NombreCircunscripcion { get; set; }

            public int CantidadMujeres { get; set; }

            public int CantidadIndigenas { get; set; }

            public int CantidadAfromexicanos { get; set; }

            public int CantidadDiscapacidad { get; set; }

            public int CantidadMigrantes { get; set; }

            public int CantidadDiversidadSexual { get; set; }

            public int CantidadHombres { get; set; }
            
            public int LugaresTotales { get; set; }
            
            public int PersonasIndigenas { get; set; }

            public int CantidadIndigenasMujeresRegistrados { get;set; }

            public int CantidadIndigenasHombresRegistrados { get; set; }

            public int RequisitoIndigena { get; set; }

            public List<string> Estados { get; set; }

            public int RequisitoMigrante { get; set; }

            public int RequisitoMujeres { get; set; }
        }

        public class AnalisisCategoria
        {
            public int CandidatosCategoria { get; set; }
            
            public int TotalCandidatos { get; set; }
            
            public int CantidadMujeres { get; set; }
            
            public int CantidadHombres { get; set; }

            public int Requisito { get; set; }

            public int CumpleParidad { get; set; }

            public int CumpleRequisitoRegistro { get; set; }
        }

        [HttpGet("ObtenerDetalleDiputadosMR")]
        public async Task<IActionResult> GetObtenerDetalleDiputadosMR()
        {
            //variablesParaSaberCuantosRegistrosLLevamosParaCadaAccion
            int cantidatosTotales;

            //obtener Catalogo Representate
            var catalogoRepresentante = await _context.CatalogoRepresentante
                .Where( drd => drd.Id == 2)
                .FirstOrDefaultAsync();

            var circunscripciones = await _context.CatalogoCircunscripcion.ToListAsync();
            
            //Obtenemos los requisitos
            var detalleRequisito = await _context.DetalleRequisitoDiputaciones
                .Include(d => d.EstadoCircunscripcion)
                .ToListAsync();

            //DatosEsperadosGenerales
            var datosEsperadosGeneral = await _context.DatosEsperadosPorTipoCandidatura
                .Where(detc => detc.CatalogoRepresentanteId == 2 && detc.Activo == true)
                .OrderByDescending(detc => detc.AnioElecciones)
                .FirstOrDefaultAsync();

            var cantidadRequisitoIndigena = Convert.ToInt32(datosEsperadosGeneral.CantidadAdscripcionIndigena);
            var indigenasPorBloque = cantidadRequisitoIndigena != 0 ? cantidadRequisitoIndigena / 3 : 0;

            cantidatosTotales = datosEsperadosGeneral.CandidatosTotales;

            // Obtener bloques de personas indígenas
            var bloquesPersonasIndigenas = ObtenerDistritosIndigenas();

            // Obtener bloques Distritos Que aplican bloque Alta
            var distritosBloqueAlta = bloquesPersonasIndigenas.GetValueOrDefault("ALTA")?
                .Take(6)
                .ToList() ??
                new List<DistritosFederales>();

            // Obtener bloques Distritos Que aplican bloque Media
            var distritosBloqueMedia = bloquesPersonasIndigenas.GetValueOrDefault("MEDIA") ?
                .Take(6)
                .ToList() ??
                new List<DistritosFederales>();

            // Obtener bloques Distritos Que aplican bloque Alta
            var distritosBloqueBaja = bloquesPersonasIndigenas.GetValueOrDefault("BAJA")?
                .Take(6)
                .ToList() ??
                new List<DistritosFederales>();

            //ObtenerCandidatos Inscritos por bloqueCompetitividad
            var candidatosExistentesBloqueAlta = await ObtenerCandidatosPorBloque("ALTA");

            var candidatosExistentesBloqueMedia = await ObtenerCandidatosPorBloque("MEDIA");

            var candidatosExistentesBloqueBaja = await ObtenerCandidatosPorBloque("BAJA");

            var resultadoRequisitosDiputadosMR = detalleRequisito
                .GroupBy(dr => dr.EstadoCircunscripcion.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    TotalCandidatosDipuadosMayoriaRelativa = group.Sum(dr => dr.CandidatosDiputadosMayoriaRelativa),
                    TotalMujeresDiputadosMayoriaRelativa = group.Sum(dr => dr.MujeresDiputadosMayoriaRelativa),
                    TotalFormulasMayoriaRelativa = group.Sum(dr => dr.FormulasMayoriaRelativa)
                }).ToList();

            var categorias = new List<string>
            {
                "PersonasIndigenas",
                "PersonasAfromexicanas",
                "DiversidadSexual",
                "Discapacidad",
                "Migrantes",
                "Mujeres"
            };

            var resultadosPorCategoria = categorias.Select(categoria =>
            {
                var candidatosPorCategoria = ObtenerCandidatosPorCategoria(2, categoria, true, circunscripciones);
                return new
                {
                    Categoria = categoria,
                    CandidatosPorCategoria = candidatosPorCategoria
                };
            }).ToList();

            //Analisis Indigenas
            //bloqueALta
            var analisisBloqueAlta = CalcularAnalisisBloque(candidatosExistentesBloqueAlta, "ALTA", indigenasPorBloque);
            //Fin AnalisisIndigenas

            //bloqueMedia
            var analisisBloqueMedia = CalcularAnalisisBloque(candidatosExistentesBloqueMedia, "MEDIA", indigenasPorBloque);
            // fin bloque Media

            //bloqueBaja
            var analisisBloqueBaja = CalcularAnalisisBloque(candidatosExistentesBloqueBaja, "BAJA", indigenasPorBloque);
            // fin bloque Baja


            var analisisGeneralBloques = CalcularSumatoriaGeneralIndigenas(analisisBloqueAlta, analisisBloqueMedia, analisisBloqueBaja);

            //Fin AnalisisIndigenas

            //Análisis Discapacitado

            var discapacidadMR = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Discapacidad")?.CandidatosPorCategoria;

            int totalCandidatosDiscapacidadMR = discapacidadMR?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiscapacidad = discapacidadMR!=null
                ? discapacidadMR.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 2)
                :0;

            int cantidadHombresDiscapacidad = discapacidadMR != null
                ? discapacidadMR.SelectMany(c => c.Candidatos).Count(c => c.Persona.GeneroId == 1)
                : 0;

            int requisitoDiscapacidad = datosEsperadosGeneral.CantidadDiscapacitados;

            bool cumpleParidadDiscapacidad = cantidadMujeresDiscapacidad >= cantidadHombresDiscapacidad;

            bool cumpleRequisitoRegistroDiscapacitado = totalCandidatosDiscapacidadMR >= requisitoDiscapacidad;

            var analisisDiscapacitado = new { 
                discapacidadMR,
                totalCandidatosDiscapacidadMR,
                cantidadMujeresDiscapacidad,
                cantidadHombresDiscapacidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoDiscapacidad,
                cumpleParidadDiscapacidad,
                cumpleRequisitoRegistroDiscapacitado,
            };

            //Fin Análisis Discapacitado

            //Análisis Diversidad Sexual 
            var diversidadSexualMR = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "DiversidadSexual")?.CandidatosPorCategoria;

            int totalCandidatosDiversidadSexual = diversidadSexualMR?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresDiversidad = diversidadSexualMR != null
                ? diversidadSexualMR.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.DiversidadSexual == true 
                    && ds.Persona.GeneroId == 2 )
                : 0;

            int cantidadHombresDiversidad = diversidadSexualMR != null
                ? diversidadSexualMR.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.DiversidadSexual == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoDiversidadSexual = datosEsperadosGeneral.CantidadDiversidadSexual;

            bool cumpleParidadDiversidad = cantidadMujeresDiversidad >= cantidadHombresDiversidad;

            bool cumpleRequisitoRegistroDiversidad = totalCandidatosDiversidadSexual >= requisitoDiversidadSexual;

            var analisisisDiversidadSexual = new
            {
                diversidadSexualMR,
                totalCandidatosDiversidadSexual,
                cantidadMujeresDiversidad,
                cantidadHombresDiversidad,
                requisitoDiversidadSexual,
                cumpleParidadDiversidad,
                cumpleRequisitoRegistroDiversidad,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
            };
            //Fin Análisis Diversidad Sexual 

            //Análisis Migrantes
            var migrantesMR = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Migrantes")?.CandidatosPorCategoria;

            int totalCandidatosMigrantesMR = migrantesMR?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresMigrantes = migrantesMR != null
                ? migrantesMR.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresMigrantes = migrantesMR != null
                ? migrantesMR.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoMigrantes = datosEsperadosGeneral.CantidadPersonaMigrante; ;

            bool cumpleParidadMigrante = cantidadMujeresMigrantes >= cantidadHombresMigrantes;

            bool cumpleRequisitoRegistroMigrante = totalCandidatosMigrantesMR >= requisitoMigrantes;

            var analisisMigrantes = new
            {
                migrantesMR,
                totalCandidatosMigrantesMR,
                cantidadMujeresMigrantes,
                cantidadHombresMigrantes,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoMigrantes,
                cumpleParidadMigrante,
                cumpleRequisitoRegistroMigrante,
            };

            //Fin Análisis Migrantes

            //Analisis afrodescendientes

            var personasAfromexicanasMR = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasAfromexicanas")?.CandidatosPorCategoria;

            int totalCandidatosAfromexicanasMR = personasAfromexicanasMR?.Sum(item => item.Cantidad) ?? 0;

            int cantidadMujeresAfromexicanas = migrantesMR != null
                ? migrantesMR.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 2)
                : 0;

            int cantidadHombresAfromexicanas = migrantesMR != null
                ? migrantesMR.SelectMany(ds => ds.Candidatos).Count(ds => ds.CandidatosChc.MexicanosMigrantes == true
                    && ds.Persona.GeneroId == 1)
                : 0;

            int requisitoAfromexicana = datosEsperadosGeneral.CantidadAfromexicanos;

            bool cumpleParidadAfromexicana = cantidadMujeresMigrantes >= cantidadHombresAfromexicanas;

            bool cumpleRequisitoRegistroAfromexicana = totalCandidatosAfromexicanasMR >= requisitoMigrantes;

            var analisisAfromexicanas = new 
            {
                personasAfromexicanasMR,
                totalCandidatosAfromexicanasMR,
                cantidadMujeresAfromexicanas,
                cantidadHombresAfromexicanas,
                mujeresNecesarios = 0,
                HombresNecesarios = 0,
                requisitoAfromexicana,
                cumpleParidadAfromexicana,
                cumpleRequisitoRegistroAfromexicana
            };

            //Fin Analisis afrodescendientes


            var mujeres = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "Mujeres")?.CandidatosPorCategoria;

            int totalCandidatosMujeresMR = mujeres?.Sum(item => item.Cantidad) ?? 0;   

            var personasIndigenasMR = resultadosPorCategoria.FirstOrDefault(c => c.Categoria == "PersonasIndigenas")?.CandidatosPorCategoria;

            int totalCandidatosIndigenasMR = personasIndigenasMR?.Sum(item => item.Cantidad) ?? 0;

            var resultadosExistentes = _context.CandidatoPersona
                .Where(cp => cp.CandidatosChc.EsAccionesAfirmativas == true && 
                        cp.CandidatosChc.Activo == true && 
                        cp.CandidatosChc.RepresentanteId == 2
                        )
                .GroupBy(cp => cp.CandidatosChc.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    CantidadMujeres = group.Count( cp => cp.Persona.GeneroId == 1),
                    CantidadIndigenas = group.Count(cp => cp.CandidatosChc.IdentificacionIndigena == true),
                    CantidadAfromexicanos = group.Count(cp => cp.CandidatosChc.Afromexicanas == true),
                    CantidadDiscapacidad = group.Count(cp => cp.CandidatosChc.ConDiscapacidad == true),
                    CantidadMigrantes = group.Count(cp => cp.CandidatosChc.MexicanosMigrantes == true),
                    CantidadDiversidadSexual = group.Count(cp => cp.CandidatosChc.DiversidadSexual == true),
                    CantidadHombres = group.Count(cp => cp.Persona.GeneroId == 2)
                }).ToList();

            var resultadoPorCircunscripcion = circunscripciones
                .Select(catalogo => new
                {
                    CircunscripcionId = catalogo.Id,
                    ShortId = catalogo.ShortId,
                    NombreCircunscripcion = catalogo.Nombre, // Puedes agregar el nombre si está en el catálogo
                    // Obtener los resultados existentes o establecer a 0 si no existen
                    CantidadMujeres = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadMujeres ?? 0,
                    CantidadIndigenas = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadIndigenas ?? 0,
                    CantidadAfromexicanos = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadAfromexicanos ?? 0,
                    CantidadDiscapacidad = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadDiscapacidad ?? 0,
                    CantidadMigrantes = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadMigrantes ?? 0,
                    CantidadDiversidadSexual = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadDiversidadSexual ?? 0,
                    CantidadHombres = resultadosExistentes.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.CantidadHombres ?? 0,
                    TotalMujeresDiputadosMr = resultadoRequisitosDiputadosMR.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.TotalMujeresDiputadosMayoriaRelativa ?? 0,
                    TotalCandidatosDiputadosMr = resultadoRequisitosDiputadosMR.FirstOrDefault(r => r.CircunscripcionId == catalogo.Id)?.TotalCandidatosDipuadosMayoriaRelativa ?? 0,
                    Estados = _context.EstadoCircunscripcion.Where (ec => ec.CircunscripcionId == catalogo.Id ).Select(ec => ec.EntidadFederativa.Nombre).ToList()
                }).ToList();

            var resultado = new
            {
                candidatosExistentesBloqueAlta,
                candidatosExistentesBloqueBaja,
                candidatosExistentesBloqueMedia,
                cantidatosTotales,
                catalogoRepresentante,
                circunscripciones,
                detalleRequisito,
                distritosBloqueAlta,
                distritosBloqueBaja,
                distritosBloqueMedia,
                indigenasPorBloque,
                mujeres,
                personasIndigenasMR,
                totalCandidatosIndigenasMR,
                resultadoRequisitosDiputadosMR,
                resultadoPorCircunscripcion,
                totalCandidatosMujeresMR,
                analisisDiscapacitado,
                analisisisDiversidadSexual,
                analisisMigrantes,
                analisisAfromexicanas,
                analisisBloqueAlta,
                analisisBloqueMedia,
                analisisBloqueBaja,
                analisisGeneralBloques,
            };

            return Ok(resultado);
        }

        private AnalisisBloque CalcularSumatoriaGeneralIndigenas (AnalisisBloque analisisBloqueAlta, AnalisisBloque analisisBloqueMedia, AnalisisBloque analisisBloqueBaja)
        {
            int sumaRequisitoMinimo = analisisBloqueAlta.RequisitoMinimo + analisisBloqueMedia.RequisitoMinimo + analisisBloqueBaja.RequisitoMinimo;
            int sumaMujeresIndigenas = analisisBloqueAlta.MujeresIndigenas + analisisBloqueMedia.MujeresIndigenas + analisisBloqueBaja.MujeresIndigenas;
            int sumaHombresIndigenas = analisisBloqueAlta.HombresIndigenas + analisisBloqueMedia.HombresIndigenas + analisisBloqueMedia.HombresIndigenas;
            int hombresNecesarios = analisisBloqueAlta.HombresNecesarios + analisisBloqueMedia.HombresNecesarios + analisisBloqueBaja.HombresNecesarios;
            int mujeresNecesarios = analisisBloqueAlta.MujeresNecesarios + analisisBloqueMedia.MujeresNecesarios + analisisBloqueBaja.MujeresNecesarios;
            bool cumpleRequisitoBloque = analisisBloqueAlta.CumpleRequisitoBloque && analisisBloqueMedia.CumpleRequisitoBloque && analisisBloqueBaja.CumpleRequisitoBloque;
            bool cumpleParidad = analisisBloqueAlta.CumpleParidad && analisisBloqueMedia.CumpleParidad && analisisBloqueBaja.CumpleParidad;

            var resumenBloquesIndigenas = new AnalisisBloque
            {
                RequisitoMinimo = sumaRequisitoMinimo,
                CantidadActual = sumaHombresIndigenas + sumaMujeresIndigenas,
                MujeresIndigenas = sumaMujeresIndigenas,
                HombresIndigenas = sumaHombresIndigenas,
                HombresNecesarios = hombresNecesarios,
                MujeresNecesarios = mujeresNecesarios,
                CumpleRequisitoBloque = cumpleRequisitoBloque,
                CumpleParidad = cumpleParidad,
            };

            return resumenBloquesIndigenas;
        }

        private AnalisisBloque CalcularAnalisisBloque(List<CandidatoPersona> candidatosExistentes, string bloque, int indigenasPorBloque)
        {
            int mujeresIndigenas = candidatosExistentes.Count(c => c.Persona.GeneroId == 2);
            int hombresIndigenas = candidatosExistentes.Count(c => c.Persona.GeneroId == 1);
            bool cumpleRequisitoBloque = candidatosExistentes.Count() >= indigenasPorBloque;
            bool cumpleParidad = false;

            int mitad = indigenasPorBloque / 2;

            int mujeresNecesarias = mitad;
            int hombresNecesarios = indigenasPorBloque - mitad;

            if(indigenasPorBloque%2 != 0)
            {
                mujeresNecesarias++;
            }

            cumpleParidad = mujeresIndigenas >= mujeresNecesarias && hombresIndigenas >= hombresNecesarios;

            return new AnalisisBloque
            {
                RequisitoMinimo = indigenasPorBloque,
                CantidadActual = mujeresIndigenas + hombresIndigenas,
                MujeresIndigenas = mujeresIndigenas,
                HombresIndigenas = hombresIndigenas,
                HombresNecesarios = hombresNecesarios,
                MujeresNecesarios = mujeresNecesarias,
                CumpleRequisitoBloque = cumpleRequisitoBloque,
                CumpleParidad = cumpleParidad,
            };
        }

        public class AnalisisBloque
        {
            public int RequisitoMinimo { get; set; }
            
            public int CantidadActual { get; set; }

            public int MujeresIndigenas { get; set; }

            public int MujeresNecesarios { get; set; }

            public int HombresNecesarios { get; set; }
            
            public int HombresIndigenas { get; set; }
            
            public bool CumpleRequisitoBloque { get; set; }

            public bool CumpleParidad { get; set; }
        }

        private List<CategoriaCandidatosPorEstados> ObtenerCandidatosPorCategoriaEstado(int representanteId, string categoria,
            bool esAccionesAfirmativas, List<EntidadFederativa> entidadFederativas)
        {
            var resultados = new List<CategoriaCandidatosPorEstados>();

            foreach (var estados in entidadFederativas)
            {
                var candidatos = _context.CandidatoPersona
                    .Include(cp => cp.Persona)
                    .Include(cp => cp.CandidatosChc)
                    .Where(cp => cp.CandidatosChc.RepresentanteId == representanteId &&
                            cp.CandidatosChc.EstadoId == estados.Id &&
                        (
                            (categoria == "PersonasIndigenas" && cp.CandidatosChc.IdentificacionIndigena == true) ||
                            (categoria == "PersonasAfromexicanas" && cp.CandidatosChc.Afromexicanas == true) ||
                            (categoria == "DiversidadSexual" && cp.CandidatosChc.DiversidadSexual == true) ||
                            (categoria == "Discapacidad" && cp.CandidatosChc.ConDiscapacidad == true) ||
                            (categoria == "Migrantes" && cp.CandidatosChc.MexicanosMigrantes == true) ||
                            (categoria == "Mujeres" && cp.Persona.Genero.Id == 2)
                        ) &&
                        cp.CandidatosChc.EsAccionesAfirmativas == esAccionesAfirmativas
                    )
                    .ToList();
                resultados.Add(new CategoriaCandidatosPorEstados
                {
                    EntidadFederativaId = estados.Id,
                    Categoria = categoria,
                    Candidatos = candidatos,
                    Cantidad = candidatos.Count
                });
            }

            return resultados;
        }

        private List<CategoriaCandidatos> ObtenerCandidatosPorCategoria(int representanteId, string categoria,
            bool esAccionesAfirmativas, List<CatalogoCircunscripcion> circunscripciones)
        {
            var resultados = new List<CategoriaCandidatos>();

            foreach (var circ in circunscripciones)
            {
                var candidatos = _context.CandidatoPersona
                    .Include(cp => cp.Persona)
                    .Include(cp => cp.CandidatosChc)
                    .Where(cp => cp.CandidatosChc.RepresentanteId == representanteId &&
                            cp.CandidatosChc.CircunscripcionId == circ.Id &&
                        (
                            (categoria == "PersonasIndigenas" && cp.CandidatosChc.IdentificacionIndigena == true) ||
                            (categoria == "PersonasAfromexicanas" && cp.CandidatosChc.Afromexicanas == true) ||
                            (categoria == "DiversidadSexual" && cp.CandidatosChc.DiversidadSexual == true) ||
                            (categoria == "Discapacidad" && cp.CandidatosChc.ConDiscapacidad == true) ||
                            (categoria == "Migrantes" && cp.CandidatosChc.MexicanosMigrantes == true) ||
                            (categoria == "Mujeres" && cp.Persona.Genero.Id == 2)
                        ) &&
                        cp.CandidatosChc.EsAccionesAfirmativas == esAccionesAfirmativas
                    )
                    .ToList();
                resultados.Add(new CategoriaCandidatos
                {
                    CircunscripcionId = circ.Id,
                    Categoria = categoria,
                    Candidatos = candidatos,
                    Cantidad = candidatos.Count
                });
            }

            return resultados;
        }

        private Dictionary<string, List<DistritosFederales>> ObtenerDistritosIndigenas()
        {
            var distritoIndigenas = _context.DistritosFederales
                .Include(df => df.CatalogoCircunscripcion)
                .OrderByDescending(d => d.McPorcentaje)
                .AsEnumerable()
                .Where(d =>
                        d.SiIndigenaMcAltoMr == true ||
                        d.SiIndigenaMcBajoMr == true ||
                        d.SiIndigenaMcMedioMr == true
                       )
                .GroupBy(d => d.McCompetitividad)
                .ToDictionary(
                    group => group.Key ?? "SinCompetitividad",
                    group => group.ToList()
                );
            
            return distritoIndigenas;
        }

        /*Prueba*/
        private List<DistritosFederales> ObtenerDistritosIndigenasPorCompetitividad(string nivelCompetitividad)
        {
            var distritoIndigenas = _context.DistritosFederales
                .Include(df => df.CatalogoCircunscripcion)
                .Include(df => df.EntidadFederativa)
                .OrderByDescending(d => d.McPorcentaje)
                .AsEnumerable()
                .Where(d =>
                        (d.SiIndigenaMcAltoMr == true && d.McCompetitividad == nivelCompetitividad) ||
                        (d.SiIndigenaMcBajoMr == true && d.McCompetitividad == nivelCompetitividad) ||
                        (d.SiIndigenaMcMedioMr == true && d.McCompetitividad == nivelCompetitividad)
                       )
                .Take(6)
                .GroupBy(d => d.McCompetitividad)
                .SelectMany(group => group)
                .ToList();

            return distritoIndigenas;
        }

        /*FIN PRUEBA*/

        //CandidatosIndigenasPorBloque
        private async Task<List<CandidatoPersona>> ObtenerCandidatosPorBloque(string bloque)
        {
            var bloquesPersonasIndigenas = _context.DistritosFederales
                .Include(df => df.CatalogoCircunscripcion)
                .OrderByDescending(d => d.McPorcentaje)
                .AsEnumerable()
                .Where(d =>
                        d.SiIndigenaMcAltoMr == true ||
                        d.SiIndigenaMcBajoMr == true ||
                        d.SiIndigenaMcMedioMr == true
                       )
                .GroupBy(d => d.McCompetitividad)
                .ToDictionary(
                    group => group.Key ?? "SinCompetitividad",
                    group => group.ToList()
                );
            var DistritosBloque = bloquesPersonasIndigenas.GetValueOrDefault(bloque)?.ToList() ?? new List<DistritosFederales>();
            var candidatosExistentesBloque = new List<CandidatoPersona>();
            int hombres, mujeres;
            foreach (var candidatoJson in DistritosBloque)
            {
                int CircuinscripcionIdJson = candidatoJson.CircunscripcionId;
                int EntidadIdJson = candidatoJson.EntidadId;
                int DistritoJson = candidatoJson.Id;

                var candidatoCoincidente = await _context.CandidatoPersona
                    .Include(cp => cp.Persona)
                    .Include(cp => cp.CandidatosChc)
                    .Where(cp =>
                        cp.CandidatosChc.CircunscripcionId == CircuinscripcionIdJson &&
                        cp.CandidatosChc.RepresentanteId == 2 &&
                        cp.CandidatosChc.EstadoId == EntidadIdJson &&
                        cp.CandidatosChc.DistritoId == DistritoJson &&
                        cp.CandidatosChc.IdentificacionIndigena == true &&
                        cp.CandidatosChc.EsAccionesAfirmativas == true)
                    .ToListAsync();

                if (candidatoCoincidente != null)
                {
                    candidatosExistentesBloque.AddRange(candidatoCoincidente);
                }
            }
            return candidatosExistentesBloque;
        }


        public class CandidatoPersonaContenedor
        {
            public int CantidadHombre { get; set; }

            public int CantidadMujeres { get; set; }
            
            public  CandidatosCHC CandidatosCHC { get; set; }

            public Persona Persona { get; set; }
        }

        public class CategoriaCandidatosPorEstados
        {
            public int EntidadFederativaId { get; set; }

            public string Categoria { get; set; }

            public List<CandidatoPersona> Candidatos { get; set; }

            public int Cantidad { get; set; }
        }


        public class CategoriaCandidatos
        {
            public int CircunscripcionId { get; set; }

            public string Categoria { get; set; }

            public List<CandidatoPersona> Candidatos { get; set; }

            public int Cantidad { get; set; }
        }

        [HttpGet("ObtenerDetalleIndigenasDiputadoMayoriaRelativa")]
        public async Task<IActionResult> GetDetalleDiputadoMayoriaRelativa()
        {
            var distritoIndigenaAlto = await _context.DistritosFederales
                .Where(d => d.BloqueConcentracionIndigena == "ALTA" && d.McCompetitividad == "ALTA")
                .OrderByDescending(d => d.McPorcentaje)
                .ToListAsync();

            var conteoDistritoIndigenaAlto = distritoIndigenaAlto
                .GroupBy(d => d.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    Cantidad = group.Count(),
                    MujeresIndigenasAlto = group.Count() % 2 == 0 ? group.Count() / 2 : (group.Count() / 2) + 1,
                    HombresIndigenasAlto = group.Count() / 2
                }).ToList();


            var distritoIndigenaMedio = await _context.DistritosFederales
                .Where(d => d.BloqueConcentracionIndigena == "ALTA" && d.McCompetitividad == "MEDIA")
                .OrderByDescending(d => d.McPorcentaje)
                .ToListAsync();

            var conteoDistritoIndigenaMedio = distritoIndigenaMedio
                .GroupBy(d => d.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    Cantidad = group.Count(),
                    MujeresIndigenasMedio = group.Count() % 2 == 0 ? group.Count() / 2 : (group.Count() / 2) + 1,
                    HombresIndigenasMedio = group.Count() / 2
                }).ToList();

            var distritoIndigenaBajo = await _context.DistritosFederales
                .Where(d => d.BloqueConcentracionIndigena == "ALTA" && d.McCompetitividad == "BAJA")
                .OrderByDescending(d => d.McPorcentaje)
                .Take(6)
                .ToListAsync();

            var conteoDistritoIndigenaBajo = distritoIndigenaBajo
                .GroupBy(d => d.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    Cantidad = group.Count(),
                    MujeresIndigenasBajo = group.Count() % 2 == 0 ? group.Count() / 2 : (group.Count() / 2) + 1,
                    HombresIndigenasBajo = group.Count() / 2
                }).ToList();

            var resumen = new
            {
                distritoIndigenaAlto,
                conteoDistritoIndigenaAlto,
                distritoIndigenaMedio,
                conteoDistritoIndigenaMedio,
                distritoIndigenaBajo,
                conteoDistritoIndigenaBajo
            };
            return Ok(resumen);
        }

        [HttpGet("ObtenerDetalleMujeresDiputado")]
        public async Task<IActionResult> GetDetalleMujeresDiputadoMayoriaRelativa()
        {
            var resultado = await _context.DetalleRequisitoDiputaciones
                .Include(d => d.EstadoCircunscripcion)
                .ToListAsync();

            var agrupados = resultado
                .GroupBy(d => d.EstadoCircunscripcion.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    TotalMujeresMayoriaRelativa = group.Sum(d => d.MujeresDiputadosMayoriaRelativa),
                    TotalMujeresRepresentacionProporcional =
                        group.Sum(d => d.MujeresDiputadosRepresentacionProporcional),
                    TotalMujeres = group.Sum(d => d.MujeresDiputadosMayoriaRelativa + d.MujeresDiputadosRepresentacionProporcional)

                }).ToList();

            return Ok(agrupados);
        }

        [HttpGet("ObtenerDetalleMujeresSenador")]
        public async Task<IActionResult> GetDetalleMujeresSenadorMayoriaRelativa()
        {
            var resultado = await _context.DetalleRequisitoDiputaciones
                .Include(d => d.EstadoCircunscripcion)
                .ToListAsync();

            var agrupados = resultado
                .GroupBy(d => d.EstadoCircunscripcion.CircunscripcionId)
                .Select(group => new
                {
                    CircunscripcionId = group.Key,
                    TotalMujeresSenadoresMayoriaRelativa = group.Sum(d => d.MujeresSenadorMayoriaRelativa),
                }).ToList();

            return Ok(agrupados);
        }

        // PUT api/<DetalleRequisitosDiputacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DetalleRequisitosDiputacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
