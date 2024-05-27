using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class EscuchaFormularioTemasInteresViewModel
    {
        public required int EscuchaId { get; set; }

        public required int FormularioTemasInteresId { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
