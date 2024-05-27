using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class EventoTipo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required string Nombre { get; set; }
    
    public required string? Descripcion { get; set; } = null;
    
    public string? Imagen { get; set; } = "https://i.imgur.com/4ZQZ5Zu.png";
    
    [Comment("True = Sesion, False = Evento")]
    public required bool TipoSesion { get; set; } = false;
    
    public bool Activo { get; set; } = true;
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}