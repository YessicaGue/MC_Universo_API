using MC_Universo_API.Models.Precandidaturas;
using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels.Precandidaturas;

public class PrecandidaturaCoadministradorViewModel
{
    public int PerfilId { get; set; }
    public int PerfilPrecandidaturaId { get; set; }
    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}
