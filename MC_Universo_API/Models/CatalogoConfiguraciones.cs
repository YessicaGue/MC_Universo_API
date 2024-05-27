using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class CatalogoConfiguraciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public String? Nombre { get; set; }

        public required String Valor { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
