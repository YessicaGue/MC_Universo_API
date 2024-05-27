using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models
{
    public class Publicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        [Comment("Para el tipo de publicaciones legacy que utilizaron esta columna para identificar al autor")]
        public int? UsuarioId { get; set; }

        [Comment("Para el tipo de publicaciones que utilizaran esta nueva columna para identificar al autor")]
        public int? PerfilId { get; set; }
        [ForeignKey("PerfilId")]
        public virtual Perfil? Perfil { get; set; }

        public int? CatalogoPublicacionId { get; set; }
        [ForeignKey("CatalogoPublicacionId")]
        public virtual CatalogoPublicaciones? CatalogoPublicaciones { get; set; }

        public Guid? Guid { get; set; }

        public required string Titulo { get; set; }

        public required string Descripcion { get; set; }

        public required string Contenido { get; set; }

        public bool Activo { get; set; } = true;

        public bool EsVisible { get; set; } = true;

        public string? Url { get; set; }

        public string? ImagenPublicacion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
