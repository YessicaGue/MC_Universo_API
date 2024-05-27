using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class Archivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required string Nombre { get; set; }

        public required string Tipo { get; set; }

        public required string Directorio { get; set; }

        public string? Slug { get; set; }

        public bool Activo { get; set; } = true;

        public bool esPublico { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        
    }
}
