using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class Sesion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }


        public required int TipoSesionId { get; set; }
        [ForeignKey("TipoSesionId")]
        public virtual CatalogoTipoSesion CatalogoTipoSesion { get; set; } = default!;

        public required int EntidadFederativaId { get; set; }
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;


        [Comment("Id del usuario dashboard que registra la sesion")]
        public required int UsuarioId { get; set; }

        public required string Direccion { get; set; }

        public string? Comentarios { get; set; }

        [Comment("Fecha en la que se registra la sesion")]
        public DateTime FechaSesion { get; set; } = DateTime.UtcNow;


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
