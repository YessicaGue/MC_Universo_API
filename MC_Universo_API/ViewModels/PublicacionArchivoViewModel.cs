using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class PublicacionArchivoViewModel
    {
        public required int PublicacionId { get; set; }
        public required int ArchivoId { get; set; }
    }
}
