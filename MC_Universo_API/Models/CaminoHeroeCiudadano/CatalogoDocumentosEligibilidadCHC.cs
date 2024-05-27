using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class CatalogoDocumentosEligibilidadCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        [Comment("Nombre corto")]
        public required string Nombre { get; set; }

        [Comment("Es importante tener una descripcion detallada sobre lo que trata y sobre la manera de entregar")]
        public string? Descripcion { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
