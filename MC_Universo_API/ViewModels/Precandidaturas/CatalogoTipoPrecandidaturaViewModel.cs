namespace MC_Universo_API.Models.Precandidaturas
{
    public class CatalogoTipoPrecandidaturaViewModel
    {
        public required string Nombre { get; set; }


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
