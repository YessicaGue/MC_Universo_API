using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class VoluntarioViewModel
    {

        public required int GeneroId { get; set; }

        public required int EscolaridadId { get; set; }

        public required int MotivoId { get; set; }

        public required int EntidadFederativaId { get; set; }

        public required int EstatusVoluntarioId { get; set; }

        public required string Nombre { get; set; }

        public required string ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public required string Direccion { get; set; }

        public required string Telefono { get; set; }

        public required string CorreoElectronico { get; set; }

        public required DateTime FechaNacimiento { get; set; }
    }
}
