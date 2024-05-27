using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PersonaViewModel
    {
        public required string Nombre { get; set; }

        public required string ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public string? Seudonimo { get; set; }

        public required DateTime FechaNacimiento { get; set; }

        public required int EntidadFederativaID { get; set; }
        
        public required int GeneroId { get; set; }

        public string CorreoElectronico { get; set; }

        public int TiempoResidencia { get; set; }

        public string? TelefonoParticular { get; set; }

        public string? FirmaElectronica { get; set; }
        
        public string? Curp { get; set; }

        public string? Rfc { get; set; }

        public string? ClaveElector { get; set; }

        public bool Activo { get; set; } = true;
        
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    }
}
