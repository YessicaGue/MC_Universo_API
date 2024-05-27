using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class RegistroOchoAccionesUsuarioCatalogoOchoAccionesViewModel
    {
        public required int RegistroOchoAccionesUsuarioId { get; set; }

        public required int CatalogoOchoAccionesId { get; set; }
    }
}
