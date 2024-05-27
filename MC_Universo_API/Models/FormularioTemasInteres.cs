using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class FormularioTemasInteres
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int? EntidadFederativaId { get; set; }
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa? EntidadFederativa { get; set; } = default!;

        public required String Nombre { get; set; }

        public required String Email { get; set; }
        
        public string? NumeroWhatsapp { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string? Ciudad { get; set; }

        public int? NivelEscolarId { get; set; }
        [ForeignKey("NivelEscolarId")] public virtual Escolaridad? Escolaridad { get; set; } = default!;

        public string? MotivoApoyo { get; set; }

        public string? Direccion { get; set; }

        public bool AceptoAvisoPrivacidad { get; set; }

        public bool EsModalRecibirTemasInteres { get; set; }

        public bool EsModalApoyarComunidad { get; set; }
        
        public bool EsModalSerParteEquipo { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
