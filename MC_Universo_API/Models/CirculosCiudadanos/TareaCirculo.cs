using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.CirculosCiudadanos;

public class TareaCirculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int PerfilResponsableId { get; set; }
    [ForeignKey("PerfilResponsableId")]
    public virtual Perfil Perfil { get; set; } = default!;

    [Column(TypeName = "varchar")]
    [StringLength(250)]
    public required string Nombre { get; set; }
    public required string Descripcion { get; set; }
    public DateTime? FechaCompromiso { get; set; }

    [Range(typeof(decimal), "5", "3")]
    public decimal Avance { get; set; }

    public bool Activo { get; set; } = true;
    public int UsuarioCreacionId { get; set; } = 2;
    public int? UsuarioModificacionId { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaModificacion { get; set; }
}