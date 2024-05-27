using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.FormularioParticipacionEventos;

public class EntidadFederativaCodigoEvento
{
    [Key]
    public required int EntidadFederativaId { get; set; }
    [ForeignKey("EntidadFederativaId")] public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;

    public int GeneradorContadoCodigo { get; set; }
}