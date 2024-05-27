using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class TareaCirculoViewModel
{
    public int PerfilResponsableId { get; set; }
    public required string Nombre { get; set; }
    public required string Descripcion { get; set; }
    public DateTime? FechaCompromiso { get; set; }
    public decimal Avance { get; set; }
    public bool Activo { get; set; } = true;
    public int? UsuarioCreacionId { get; set; }
    public int? UsuarioModificacionId { get; set; }
    public DateTime? FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}