using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels
{
    public class PerfilCatalogoRedesSocialesViewModel
    {
        public required int CatalogoRedesSocialesId { get; set; }

        public required int PerfilId { get; set; }

        public String? Url { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
