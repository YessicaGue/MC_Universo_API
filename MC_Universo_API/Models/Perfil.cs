using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models
{
    [Index(nameof(Url), IsUnique = true)]
    [Index(nameof(CustomUrl), IsUnique = true)]
    public class Perfil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public Guid Guid { get; set; } = Guid.NewGuid();

        public string? Alias { get; set; }

        [Comment("Esta columna permite describir el perfil como autobiografia")]
        public string? Descripcion { get; set; }

        public bool Activo { get; set; } = true;

        public required string Url { get; set; }

        [Comment("Esta columna permite al perfil elegir un enlace personalizado")]
        public string? CustomUrl { get; set; }

        [Comment("Esta columna indica si el perfil es publico o privado")]
        public bool esPublico { get; set; } = true;
        
        [Comment("Esta columna indica si el perfil es verificado.")]
        public bool esVerificado { get; set; } = false;
        
        [Comment("Esta columna indica si el perfil es un candidato aprobado.")]
        public bool esCandidato { get; set; } = false;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaBaja { get; set; }
    }
}