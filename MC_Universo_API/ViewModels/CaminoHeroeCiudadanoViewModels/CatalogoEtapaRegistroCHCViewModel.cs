namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;

public class CatalogoEtapaRegistroCHCViewModel
{
    public required string Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? NombreURLRoute { get; set; }

    public int IndiceOrden { get; set; }

    public bool Activo { get; set; } = true;

    public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
    
    public float? Porcentaje { get; set; }
    
}
