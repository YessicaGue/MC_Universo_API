using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class Evento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public required string Nombre { get; set; } = default!;
    
    public string? Descripcion { get; set; } = "";
    
    public required DateTime FechaEvento { get; set; } = DateTime.UtcNow;

    public string Imagen { get; set; } = "https://i.imgur.com/4ZQZ5Zu.png";
    
    public required int EventoTipoId { get; set; }
    [ForeignKey("EventoTipoId")]
    public virtual EventoTipo EventoTipo { get; set; } = default!;
    
    [Comment("1 = Publico, 2 = Lista de invitados, 3 = Privado")]
    public required int Privacidad { get; set; } = 1;
    
    // Coordenadas y direccion
    public required string Direccion { get; set; }
    public required string Latitud { get; set; }
    public required string Longitud { get; set; }
    
    public required bool CupoLimitado { get; set; }
    public required int NumeroAsistentes { get; set; }
    public required bool CheckInRequerido { get; set; }
    
    [Comment("Persona que creo el evento o es el responsable del mismo")]
    [Column("responsable_id")]
    public required int PersonaId { get; set; }
    [ForeignKey("PersonaId")]
    public virtual Persona Persona { get; set; } = default!;
    
    public required bool Activo { get; set; } = true;
    
    // CreatedAt UpdateAt DeleteAt
    public DateTime? FechaCreacion { get; set; } = DateTime.UtcNow;
    
    public DateTime? FechaModificacion { get; set; } = DateTime.UtcNow;
    
    public DateTime? FechaEliminacion { get; set; } = null;
}