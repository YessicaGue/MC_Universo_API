using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.CirculosCiudadanos;

public class PerfilCirculoViewModel
{
    public int PerfilId { get; set; }
    public int CirculoId { get; set; }
    public required string RutaCedulaRegistro { get; set; }
    public bool PuedeGenerarInvitacion { get; set; }
    [Column(TypeName = "varchar")]
    [StringLength(250)]
    public string? Nombre { get; set; }
    [Column(TypeName = "varchar")]
    [StringLength(200)]
    public string? PrimerApellido { get; set; }
    [Column(TypeName = "varchar")]
    [StringLength(200)]
    public string? SegundoApellido { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public int? EntidadFederativaId { get; set; }
    public virtual EntidadFederativa? EntidadFederativa { get; set; }
    public int? GeneroId { get; set; }
    public virtual Genero? Genero { get; set; }
    public string? Calle { get; set; }
    public string? NoExterior { get; set; }
    public string? NoInterior { get; set; }
    public string? CodigoPostal { get; set; }
    public string? Colonia { get; set; }
    public string? Municipio { get; set; }
    public string? Celular { get; set; }
    public int MovilSistemaOperativo { get; set; }
    public string? TelefonoFijo { get; set; }
    public string? Cargo { get; set; }
    [Column(TypeName = "varchar")]
    [StringLength(200)]
    public string? Email { get; set; }
    public string? LigaFacebook { get; set; }
    public string? LigaTwitter { get; set; }
    public string? ClaveElector { get; set; }
    public string? ClaveMunicipio { get; set; }
    public string? SeccionElectoral { get; set; }
    [Column(TypeName = "varchar")]
    [StringLength(18)]
    public string? Curp { get; set; }
    public string? Localidad { get; set; }
    public string? Firma { get; set; }
    public bool IsAvisoAceptado { get; set; }
    public bool Activo { get; set; } = true;
    public int? UsuarioCreacionId { get; set; }
    public int? UsuarioModificacionId { get; set; }
    public DateTime? FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}