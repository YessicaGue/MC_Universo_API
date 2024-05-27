using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.Change;

public class ChangePeticion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    // Guid
    public Guid Guid { get; set; } = Guid.NewGuid();
    
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    
    [ForeignKey("IdCausa")]
    public int? IdCausa { get; set; }
    public virtual Causa Causa { get; set; }
    
    public bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; set; } = DateTime.UtcNow;
    public DateTime? FechaEliminacion { get; set; } = null;
}