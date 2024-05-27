using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class CatalogoPreguntasEncuestasViewModel
    {
        public int CategoriaPreguntaId { get; set; }

        public required string Nombre { get; set; }
    }
}
