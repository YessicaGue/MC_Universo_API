using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class ProgramaResponsableViewModel
    {
        public required int ProgramaId { get; set; }

        public required int ResponsableId { get; set; }
    }
}
