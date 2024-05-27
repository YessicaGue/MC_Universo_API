using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class RegistroCausa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public virtual Genero Genero { get; set; } = default!;

        public required int EscolaridadId { get; set; }
        [ForeignKey("EscolaridadId")]
        public virtual Escolaridad Escolaridad { get; set; } = default!;

        public required int EntidadFederativaId { get; set; }
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;

        public required string Nombre { get; set; }

        public required string ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public required string Direccion { get; set; }

        public required DateTime FechaNacimiento { get; set; }
    }
}
