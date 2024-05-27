using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MC_Universo_API.Models
{
    public class Escucha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required string Respuesta { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
