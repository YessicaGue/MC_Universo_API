using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class CatalogoEtapasCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int CaminoId { get; set; }
        [ForeignKey("CaminoId")]
        public virtual CatalogoCaminosCHC CatalogoCaminosCHC { get; set; } = default!;

        public int TipoEtapaId { get; set; }
        [ForeignKey("TipoEtapaId")]
        public virtual CatalogoTiposEtapasCHC CatalogoTiposEtapasCHC { get; set; } = default!;

        public required string Nombre { get; set; }

        public string? Descripcion { get; set; }

        [Comment("Fecha en la que la etapa va a terminar")]
        public DateTime FechaLimite { get; set; } = DateTime.UtcNow;

        [Comment("Indice Orden atributo sirve para ver el orden qe se mostraran las etapas")]
        public int? IndiceOrden { get; set; }

        [Comment("Url Pagina es la url de la vista")]
        public string? NombreUrlRoute { get; set; }
        
        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
