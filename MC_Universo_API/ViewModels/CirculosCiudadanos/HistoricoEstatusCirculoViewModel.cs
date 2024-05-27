using MC_Universo_API.Models.CirculosCiudadanos;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class HistoricoEstatusCirculoViewModel
{
    public int EstatusAnteriorId { get; set; }
    public int EstatusNuevoId { get; set; }
    public string? ComentarioEstatus { get; set; }
    public bool Activo { get; set; } = true;
    public int? UsuarioCreacionId { get; set; }
    public int? UsuarioModificacionId { get; set; }
    public DateTime? FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}