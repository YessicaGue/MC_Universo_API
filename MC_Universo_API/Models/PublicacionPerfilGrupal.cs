using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models
{
    public class PublicacionPerfilGrupal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        [Comment("Esta columna es opcional y registra al usuario dashboard administrador de este perfil grupal que realiza la publicacion")]
        public int? UsuarioId { get; set; }

        [Comment("Esta columna es opcional y registra al perfil ajeno a dashboard administrador de este perfil grupal que realiza la publicacion")]
        public int? PerfilUsuarioId { get; set; }
        [ForeignKey("PerfilUsuarioId")]
        public virtual PerfilUsuario? PerfilUsuario { get; set; }

        public int PerfilGrupalId { get; set; }
        [ForeignKey("PerfilGrupalId")]
        public virtual PerfilGrupal PerfilGrupal { get; set; } = default!;

        public int? CatalogoPublicacionPerfilGrupalId { get; set; }
        [ForeignKey("CatalogoPublicacionPerfilGrupalId")]
        public virtual CatalogoPublicacionesPerfilGrupal? CatalogoPublicacionesPerfilGrupal { get; set; }

        public Guid? Guid { get; set; }

        public required string Titulo { get; set; }

        public required string Descripcion { get; set; }

        public required string Contenido { get; set; }

        public bool Activo { get; set; }

        public string? Url { get; set; }

        public string? ImagenPublicacion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public string? UrlMovimientoSocial { get; set; } 

        public DateTime FechaCreacion { get; set; }
    }
}
