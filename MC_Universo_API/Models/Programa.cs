using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class Programa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required string Nombre { get; set; }

        public required string Localidad { get; set; }

        public required string Descripcion { get; set; }

        public bool? Activo { get; set; } = true;

        public required int CantidadCupo { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }
    }
}
