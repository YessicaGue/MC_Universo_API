using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class RegistroSegundaRondaViewModel
    {
        public required int CaminoId { get; set; }
        
        public required int PerfilId { get; set; }
        
        public string? CargoPostulacion { get; set; }
        
        public DateTime? FechaIngresoMC { get; set; }
        
        public required string PuestoEleccionPopularAnteriores { get; set; }
        
        public required string CargosDesempeniadosDentroMC { get; set; }
        
        public required string Comentarios { get; set; }
        
        public required string CURP { get; set; }

        public required string RFC { get; set; }

        public required string ClaveElector { get; set; }

        public required DireccionViewModel DireccionViewModel { get; set; }

    }
}
