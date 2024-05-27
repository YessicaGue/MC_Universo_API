using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MC_Universo_API.Models.AccionesAfirmativas
{
    [Index(nameof(ShortId), IsUnique = true)]
    public class CatalogoAccionesAfirmativas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required string ShortId { get; set; }

        public required string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

    }
}