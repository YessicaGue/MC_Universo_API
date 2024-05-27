using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.CirculosCiudadanos;

public class Circulo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Comment("Id de perfil de quien crea el circulo")]
    public int PerfilFundadorId { get; set; }
    [ForeignKey("PerfilFundadorId")]
    public virtual Perfil Perfil { get; set; } = default!;
    public int? EstatusActualHistoricoCirculoId { get; set; }
    [ForeignKey("EstatusActualHistoricoCirculoId")]
    public virtual HistoricoEstatusCirculo? HistoricoEstatusCirculo { get; set; }

    public int EntidadFederativaId { get; set; }
    [ForeignKey("EntidadFederativaId")]
    public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;

    [Column(TypeName = "varchar")]
    [StringLength(250)]
    public required string Nombre { get; set; }
    public string? Descripcion { get; set; }

    public string? Direccion { get; set; }

    public string? CausaPrioritariaUno { get; set; }
    public string? CausaPrioritariaDos { get; set; }
    public string? CausaPrioritariaTres { get; set; }

    [Column(TypeName = "varchar")]
    [StringLength(250)]
    public string? RutaActaConstitutiva { get; set; }
    public Guid? GuidInvitacion { get; set; }

    [Column(TypeName = "varchar")]
    [StringLength(250)]
    public string? LigaInvitacion { get; set; }

    public string? Folio { get; set; }

    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}