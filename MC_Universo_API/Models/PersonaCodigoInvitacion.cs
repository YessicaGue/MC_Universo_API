using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[PrimaryKey("CodigoInvitacionId", "PersonaId")]
public class PersonaCodigoInvitacion
{
    // Id del codigo de invitacion del sponsor
    public int CodigoInvitacionId { get; set; }
    [NotMapped]
    public CodigoInvitacion CodigoInvitacion { get; set; } = default!;

    // Id del invitado
    public int PersonaId { get; set; }
    [NotMapped]
    public Persona Persona { get; set; } = default!;

    [DefaultValue(null)]
    public DateTime? FechaAceptado { get; set; }
}