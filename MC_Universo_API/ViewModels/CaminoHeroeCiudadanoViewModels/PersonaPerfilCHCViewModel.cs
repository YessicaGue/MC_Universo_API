using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels
{
    public class PersonaPerfilCHCViewModel
    {
        public int PerfilId { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;

    }
}
