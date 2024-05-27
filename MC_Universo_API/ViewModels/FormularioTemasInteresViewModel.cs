using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class FormularioTemasInteresViewModel
    {
        public int? EntidadFederativaId { get; set; }
        
        public required String Nombre { get; set; }

        public required String Email { get; set; }
        
        public string? NumeroWhatsapp { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string? Ciudad { get; set; }

        public int? NivelEscolarId { get; set; }

        public string? MotivoApoyo { get; set; }

        public String? Direccion { get; set; }
        
        public bool AceptoAvisoPrivacidad { get; set; }

        public bool? EsModalRecibirTemasInteres { get; set; }

        public bool? EsModalApoyarComunidad { get; set; }

        public bool? EsModalSerParteEquipo { get; set; }
        
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
