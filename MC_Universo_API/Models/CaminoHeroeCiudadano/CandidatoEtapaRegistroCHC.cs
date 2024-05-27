using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano;

public class CandidatoEtapaRegistroCHC
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int CandidatoId { get; set; }
    [ForeignKey("CandidatoId")]
    public virtual CandidatosCHC CandidatosCHC { get; set; }

    public int RegistroId { get; set; }
    [ForeignKey("RegistroId")]
    public virtual CatalogoEtapaRegistroCHC CatalogoEtapaRegistroCHC { get; set; }

    public bool Activo { get; set; } = true;

    public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
}