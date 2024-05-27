using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class RegistroOchoAccionesHabilidadViewModel
    {
        public required int RegistroOchoAccionesId { get; set; }

        public required int HabilidadId { get; set; }
    }
}
