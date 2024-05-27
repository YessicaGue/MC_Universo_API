using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Models.AccionesAfirmativas;

public class CandidatoPersona
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required int CandidatoId { get; set; }
    [ForeignKey("CandidatoId")] 
    public virtual CandidatosCHC CandidatosChc { get; set; } = default!;
    
    public int PersonaId { get; set; }
    [ForeignKey("PersonaId")] 
    public virtual Persona Persona { get; set; } = default!;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public bool Activo { get; set; } = true;
}