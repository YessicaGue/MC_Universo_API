using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class DireccionViewModel
    {
        public required string DireccionCompleta { get; set; }

        public string? NumeroCalle { get; set; }
        public string? NombreCalle { get; set; }

        public string? Colonia { get; set; }
        public required string Ciudad { get; set; }

        public required int EntidadFederativaId { get; set; }
        
        public string? CodigoPostal { get; set; }
        
        public required string Pais { get; set; }

        public required string Latitud { get; set; }
        
        public required string Longitud { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        
        public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    }
}
