using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.FormularioParticipacionEventos
{
    public class DomiclioGeneralViewModel
    {
        public required string DireccionCompleta { get; set; }

        public string? NumeroCalle { get; set; }

        public string? NombreCalle { get; set; }

        public string? Colonia { get; set; }

        public string? Ciudad { get; set; }

        public int? EntidadFederativaId { get; set; }
        
        public string? CodigoPostal { get; set; }

        public required string Pais { get; set; }

        public required string Latitud { get; set; }

        public required string Longitud { get; set; }
        
        public string? Municipio { get; set; }
    }
}
