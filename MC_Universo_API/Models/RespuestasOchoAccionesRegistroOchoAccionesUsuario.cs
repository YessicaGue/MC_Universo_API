using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class RespuestasOchoAccionesRegistroOchoAccionesUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int RegistroOchoAccionesUsuarioId { get; set; }
        [ForeignKey("RegistroOchoAccionesUsuarioId")]
        public virtual RegistroOchoAccionesUsuario RegistroOchoAccionesUsuario { get; set; } = default!;

        public int PreguntaId { get; set; }
        [ForeignKey("PreguntaId")]
        public virtual CatalogoPreguntasOchoAcciones CatalogoPreguntasOchoAcciones { get; set; } = default!;

        public required string Respuesta { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
