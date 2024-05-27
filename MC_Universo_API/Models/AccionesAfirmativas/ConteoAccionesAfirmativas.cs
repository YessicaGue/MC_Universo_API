using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.AccionesAfirmativas
{
    public class ConteoAccionesAfirmativas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int AccionAfirmativaId { get; set; }
        [ForeignKey("AccionAfirmativaId")]
        public virtual CatalogoAccionesAfirmativas CatalogoAccionesAfirmativas { get; set; }

        public int RepresentanteId { get; set; }
        [ForeignKey("RepresentanteId")]
        public virtual CatalogoRepresentante CatalogoRepresentante { get; set; }

        public int RequisitoMinimo { get; set; }

        [DefaultValue(0)]
        public int ConteoCandidatos { get; set; }

        [DefaultValue(0)]
        public int ConteoHombres { get; set; }

        [DefaultValue(0)]
        public int ConteoMujeres { get; set; }


        public required bool Activo { get; set; } = true;


        public required DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}