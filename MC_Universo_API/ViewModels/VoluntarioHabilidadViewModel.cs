using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class VoluntarioHabilidadViewModel
    {
        public required int VoluntarioId { get; set; }

        public required int HabilidadId { get; set; }
    }
}
