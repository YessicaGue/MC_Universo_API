using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class RegistroOchoAccionesCatalogoOchoAccionesViewModel
    {
        public required int RegistroOchoAccionesId { get; set; }

        public required int CatalogoOchoAccionesId { get; set; }
    }
}
