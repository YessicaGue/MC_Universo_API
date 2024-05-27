using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class TipoContacto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public required string Nombre { get; set; }
    
    public bool EsEmail { get; set; } = false;
    
    public bool EsTelefono { get; set; } = false;
    [Comment("Si es un telefono, se define si este tiene whatsapp o no")]
    public bool EsWhatsapp { get; set; } = false;
    
    public bool EsOtro { get; set; } = true;
    
    public bool Activo { get; set; } = true;
}