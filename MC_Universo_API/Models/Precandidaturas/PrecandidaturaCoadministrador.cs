using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.Precandidaturas;

public class PrecandidaturaCoadministrador
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int PerfilId { get; set; }
    [ForeignKey(nameof(PerfilId))]
    public virtual Perfil Perfil { get; set; } = default!;

    public int PerfilPrecandidaturaId { get; set; }
    [ForeignKey(nameof(PerfilPrecandidaturaId))]
    public virtual PerfilPrecandidatura PerfilPrecandidatura { get; set; } = default!;

    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}
