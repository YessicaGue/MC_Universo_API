using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.CaminoHeroeCiudadano;

public class CatalogoEtapaRegistroCHC
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public string? NombreURLRoute { get; set; }
    public int IndiceOrden { get; set; }
    public bool Activo { get; set; } = true;
    public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
}