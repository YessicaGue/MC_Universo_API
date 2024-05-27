using MC_Universo_API.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class EscuchaViewModel
    {

        public required string Respuesta { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
