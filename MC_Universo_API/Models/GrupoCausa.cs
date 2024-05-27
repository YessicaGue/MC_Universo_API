using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models;

[Index(nameof(Id), IsUnique = true)]
public class GrupoCausa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    
    public required string Nombre { get; set; }
    
    [DefaultValue(true)]
    public bool Activo { get; set; }
    
    public string UrlImagen { get; set; } = "https://i.imgur.com/1ZQ2Z1M.png";
}