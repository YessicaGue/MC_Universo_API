using MC_Universo_API.Models.CaminoHeroeCiudadano;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.AccionesAfirmativas
{
    public class DatosEsperadosPorTipoCandidatura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int CatalogoRepresentanteId { get; set; }
        [ForeignKey("CatalogoRepresentanteId")]
        public virtual CatalogoRepresentante CatalogoRepresentante { get; set; } = default!;

        public int CandidatosTotales { get; set; }

        public int CantidadMujeres { get; set; }

        public int CantidadHombres { get; set; }

        public int CantidadAdscripcionIndigena { get; set; }

        public int CantidadDiversidadSexual { get; set; }

        public int CantidadAfromexicanos { get; set; }

        public  int CantidadDiscapacitados { get; set; }

        public int CantidadPersonaMigrante { get; set; }

        public int CantidadPersonaJoven { get; set; }

        public int CantidadPersonaMayor { get; set; }

        public int AnioElecciones { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

    }
}
