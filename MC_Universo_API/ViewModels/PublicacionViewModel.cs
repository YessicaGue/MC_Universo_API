using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PublicacionViewModel
    {
        public int? UsuarioId { get; set; }

        public int? PerfilId { get; set; }

        public int? CatalogoPublicacionId { get; set; }

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
