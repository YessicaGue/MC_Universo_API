using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class CirculoViewModel
{
    public int PerfilFundadorId { get; set; }
    public int EntidadFederativaId { get; set; }
    public int? EstatusActualHistoricoCirculoId { get; set; }
    public required string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public string? Direccion { get; set; }
    public string? CausaPrioritariaUno { get; set; }
    public string? CausaPrioritariaDos { get; set; }
    public string? CausaPrioritariaTres { get; set; }
    public string? RutaActaConstitutiva { get; set; }
    public Guid? GuidInvitacion { get; set; }
    public string? LigaInvitacion { get; set; }
    public string? Folio { get; set; }
    public bool Activo { get; set; } = true;
    public int? UsuarioCreacionId { get; set; }
    public int? UsuarioModificacionId { get; set; }
    public DateTime? FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}