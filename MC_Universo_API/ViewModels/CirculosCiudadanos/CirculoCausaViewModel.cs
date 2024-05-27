using MC_Universo_API.Models.CirculosCiudadanos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class CirculoCausaViewModel
{
    public int CirculoId { get; set; }
    public int CausaId { get; set; }
    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}
