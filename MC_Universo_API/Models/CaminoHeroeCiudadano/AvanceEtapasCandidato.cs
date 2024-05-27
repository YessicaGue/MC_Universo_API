using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class AvanceEtapasCandidato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int CandidatoCHCId { get; set; }
        [ForeignKey("CandidatoCHCId")]
        public virtual CandidatosCHC CandidatosCHC { get; set; } = default!;

        public int EtapaId { get; set; }
        [ForeignKey("EtapaId")]
        public virtual CatalogoEtapasCHC CatalogoEtapasCHC { get; set; } = default!;

        public int PorcentajeAvance { get; set; }
        
        public bool? ValidoComite { get; set; }

        public DateTime FechaUltimoCambio { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

        public DateTime FechaExpiracion { get; set; }
    }
}
