using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class RegistroOchoAccionesUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int UsuarioId { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
