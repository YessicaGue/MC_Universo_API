using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models;

public class CatalogoPreguntasEncuestas
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int CategoriaPreguntaId { get; set; }
    [ForeignKey("CategoriaPreguntaId")]
    public virtual CatalogoCategoriasPreguntasEncuestas? CatalogoCategoriasPreguntasEncuestas { get; set; } = default!;

    public required string Nombre { get; set; }

    public bool? Activo { get; set; }

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}

