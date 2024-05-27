using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.Precandidaturas;

public class CatalogoPuestoPrecandidatura
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public string Nombre { get; set; } = default!;

    public string? Descripcion { get; set; } = null;

    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public DateTime? FechaModificacion { get; set; }
}