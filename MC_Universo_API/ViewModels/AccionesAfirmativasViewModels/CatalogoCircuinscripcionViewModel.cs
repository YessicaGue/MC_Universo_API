namespace MC_Universo_API.ViewModels.AccionesAfirmativas;

public class CatalogoCircuinscripcionViewModel
{
    public int Id { get; init; }
    
    public int Circunscripcion { get; set; }
    
    public string Nombre { get; set; }

    public bool Activo { get; set; } = true;

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}