using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class RegistroCausaCausaViewModel
    {
        public required int RegistroCausaId { get; set; }
        
        public required int CausaId { get; set; }
    }
}
