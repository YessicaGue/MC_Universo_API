using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{

    [Comment("Debido a que cada estado solo puede tener un tipo de comision, se establece constraint unique")]
    [Index(nameof(EntidadFederativaId), IsUnique = true)]

    public class Comision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }


        public required int TipoComisionId { get; set; }
        [ForeignKey("TipoComisionId")]
        public virtual CatalogoTipoComision CatalogoTipoComision { get; set; } = default!;

        public required int EntidadFederativaId { get; set; }
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;


        [Comment("Fecha de vigencia de comision")]
        public DateTime FechaVigencia { get; set; } = DateTime.UtcNow;

        [Comment("Esta columna almacena las periodicidades de sesiones, siendo la cantidad de sesiones por cada dia o mes o anio para los diferentes sus diferentes tipos")]
        public required string Periodicidad { get; set; }


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
