using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.FormularioParticipacionEventos
{
    public class DomicilioGeneral
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required string DireccionCompleta { get; set; }

        public string? NumeroCalle { get; set; }
        
        public string? NombreCalle { get; set; }

        public string? Colonia { get; set; }
        
        public string? Ciudad { get; set; }
        
        public string? Municipio { get; set; }
        
        public int? EntidadFederativaId { get; set; }
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa? EntidadFederativa { get; set; }

        public string? CodigoPostal { get; set; }
        
        public required string Pais { get; set; }

        public required string Latitud { get; set; }
        
        public required string Longitud { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        
        public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    }
}
