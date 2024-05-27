using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MC_Universo_API.Models.AccionesAfirmativas;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano
{
    public class CandidatosCHC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public int? PerfilId { get; set; }
        [ForeignKey("PerfilId")] public virtual Perfil? Perfil { get; set; } = default!;

        public int? CaminoId { get; set; }
        [ForeignKey("CaminoId")] public virtual CatalogoCaminosCHC? CatalogoCaminosCHC { get; set; }

        public int? CargoPostulacionId { get; set; }

        [ForeignKey("CargoPostulacionId")]
        public virtual CatalogoCargosPostulacion? CatalogoCargosPostulacion { get; set; }

        public string? CargoPostulacion { get; set; }

        public DateTime? FechaIngresoMC { get; set; }

        public string? PuestoEleccionPopularAnteriores { get; set; }

        public string? CargosDesempeniadosDentroMC { get; set; }

        public string? Comentarios { get; set; }

        public required DateTime FechaInicio { get; set; }

        public int? CircunscripcionId { get; set; }

        [ForeignKey("CircunscripcionId")]
        public virtual CatalogoCircunscripcion? CatalogoCircunscripcion { get; set; } = default!;

        public int? EstadoId { get; set; }
        [ForeignKey("EstadoId")] public virtual EntidadFederativa? EntidadFederativa { get; set; } = default!;

        public int? DistritoId { get; set; }
        [ForeignKey("DistritoId")] 
        public virtual DistritosFederales? DistritosFederales { get; set; } = default!;

        public string? NumeroLista { get; set; }

        public bool? IdentificacionIndigena { get; set; }

        public bool? Afromexicanas { get; set; }

        public bool? ConDiscapacidad { get; set; }

        public bool? PersonaJoven { get; set; }

        public bool? DiversidadSexual { get; set; }

        public bool? MexicanosMigrantes { get; set; }

        public bool? PersonaAdultoMayor { get; set; }

        public bool? EnPobreza { get; set; }

        public int? RepresentanteId { get; set; }

        [ForeignKey("RepresentanteId")]
        public virtual CatalogoRepresentante? CatalogoRepresentante { get; set; } = default!;

        public bool? DatoDePrueba { get; set; }

        public bool? EsAccionesAfirmativas { get; set; }

        public bool? EsSuplente { get; set; }

        public bool Activo { get; set; } = true;
        
        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
        
        public DateTime? FechaActualizacionSegundaRonda { get; set; } = DateTime.UtcNow;
    }
}
