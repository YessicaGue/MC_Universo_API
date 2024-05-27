using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.FormularioParticipacionEventos
{
    public class RegistroParticipantesEventos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Nombre { get; set; }

        public required string Apellidos { get; set; }

        public required int Edad { get; set; }

        public required int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public virtual Genero Genero { get; set; } = default!;

        public required string CorreoElectronico { get; set; }

        public required int DomicilioGeneralId { get; set; }
        [ForeignKey("DomicilioGeneralId")]
        public virtual DomicilioGeneral DomicilioGeneral { get; set; } = default!;

        public required string Celular { get; set; }

        public bool ParticiparEnActividades { get; set; }

        public bool MovimientoEnColonia { get; set; }

        public bool RepresentanteDeCasilla { get; set; }

        public bool ExperienciaPrevia { get; set; }

        public bool AfiliarseAMovimientoCiudadano { get; set; }

        public bool ColocarPublicidadEnDomicilio { get; set; }

        public bool AceptoTerminosCondiciones { get; set; }

        public bool AceptoMantenermeInformado { get; set; }

        public required string NombreEvento { get; set; }

        public required string OrganizadorEvento { get; set; }

        public required string LugarEvento { get; set; }
        
        public int? EntidadFederativaEventoId { get; set; }
        [ForeignKey("EntidadFederativaEventoId")]
        public virtual EntidadFederativa? EntidadFederativa { get; set; } = default!;
        
        public DateTime FechaEvento { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }  
        
        public string FolioCalculado
        {
            get
            {
                string numeroFormateado = $"{EntidadFederativaEventoId:00}";
                return $"{numeroFormateado}-{Folio.PadLeft(4,'0')}";
            }
        }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

    }
}
