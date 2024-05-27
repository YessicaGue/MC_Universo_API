namespace MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;

public class EtapaAvanceCaminoCHCViewModel
{
    public int EtapaId { get; set; }
    public string EtapaNombre { get; set; }
    public DateTime FechaLimite { get; set; }
    public int  PorcentajeAvance { get; set; }
    public bool? ValidoComite { get; set; }
    public DateTime FechaUltimocambio { get; set; }
    public DateTime FechaExpiracion { get; set; }
}