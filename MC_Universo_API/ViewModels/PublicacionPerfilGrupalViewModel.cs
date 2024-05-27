using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PublicacionPerfilGrupalViewModel
    {
        public int? UsuarioId { get; set; }

        public int? PerfilUsuarioId { get; set; }

        public int PerfilGrupalId { get; set; }

        public int? CatalogoPublicacionPerfilGrupalId { get; set; }

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
