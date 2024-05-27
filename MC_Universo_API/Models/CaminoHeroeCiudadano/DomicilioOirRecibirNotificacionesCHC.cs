using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class DomicilioOirRecibirNotificacionesCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int CandidatoId { get; set; }
        [ForeignKey("CandidatoId")]
        public virtual CandidatosCHC CandidatosCHC { get; set; }

        public int DireccionId { get; set; }
        [ForeignKey("DireccionId")]
        public virtual Direccion Direccion { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

    }
}
