using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class Voluntario
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

        public required int MotivoId { get; set; }
        [ForeignKey("MotivoId")]
        public virtual Motivo Motivo { get; set; } = default!;

        public required int EntidadFederativaId { get; set; }
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;

        public required int EstatusVoluntarioId { get; set; }
        [ForeignKey("EstatusVoluntarioId")]
        public virtual CatalogoEstatusVoluntario CatalogoEstatusVoluntario { get; set; } = default!;

        public required string Nombre { get; set; }

        public required string ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public required string Direccion { get; set; }

        [MaxLength(20)]
        public required string Telefono { get; set; }
        
        public required string CorreoElectronico { get; set; }

        public required DateTime FechaNacimiento { get; set; }

    }
}
