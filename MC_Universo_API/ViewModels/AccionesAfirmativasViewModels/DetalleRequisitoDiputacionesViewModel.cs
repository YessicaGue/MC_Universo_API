using MC_Universo_API.Models.AccionesAfirmativas;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.AccionesAfirmativasViewModels
{
    public class DetalleRequisitoDiputacionesViewModel
    {
        public required int EstadoCircunscripcionId { get; set; }
        
        public int? CandidatosDiputadosMayoriaRelativa { get; set; }

        
        public int? FormulasMayoriaRelativa { get; set; }

        public int? CandidatosDiputadosRepresentacionProporcional { get; set; }


        public int? FormulasRepresentacionProporcional { get; set; }


        public int? CandidatosSenadorMayoriaRelativa { get; set; }


        public int? CandidatosSenadorPrimeraMinoria { get; set; }


        public int? CandidatosSenadorRepresentacionProporcional { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;
    }
}
