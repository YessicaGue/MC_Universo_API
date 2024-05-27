using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels
{
    public class ProgramaAreaViewModel
    {
        public required int ProgramaId { get; set; }

        public required int AreaId { get; set; }
    }
}
