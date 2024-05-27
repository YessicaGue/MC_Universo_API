using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class SesionArchivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }


        public required int SesionId { get; set; }
        [ForeignKey("SesionId")]
        public virtual Sesion Sesion { get; set; } = default!;

        public required int ArchivoId { get; set; }
        [ForeignKey("ArchivoId")]
        public virtual Archivo Archivo { get; set; } = default!;

        public required int EstadoValidacionArchivoId { get; set; }
        [ForeignKey("EstadoValidacionArchivoId")]
        public virtual CatalogoEstadoValidacionArchivo CatalogoEstadoValidacionArchivo { get; set; } = default!;


        [Comment("Id del usuario dashboard que cambia el estado de validacion del archivo")]
        public required int UsuarioValidacionArchivoId { get; set; }

        [Comment("Id del usuario dashboard que carga el archivo")]
        public required int UsuarioCargaId { get; set; }


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
