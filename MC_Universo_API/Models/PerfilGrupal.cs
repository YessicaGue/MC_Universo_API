using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models
{
    [Comment("Debido a que cada perfil grupal puede tener ser visitable por customurl, se establece constraint unique")]
    [Index(nameof(CustomUrl), IsUnique = true)]

    public class PerfilGrupal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public Guid Guid { get; set; } = Guid.NewGuid();

        public string? Alias { get; set; }

        public string? Frase { get; set; }

        public string? Foto { get; set; }

        public string? FotoPortada { get; set; }

        public bool Activo { get; set; } = true;

        public required string Url { get; set; }

        [Comment("Esta columna permite al perfil grupal elegir un enlace personalizado")]
        public string? CustomUrl { get; set; }

        public bool esPublico { get; set; } = true;

        public string? UrlVideoPrincipal { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    }
}
