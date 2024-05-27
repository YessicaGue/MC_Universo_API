namespace MC_Universo_API.ViewModels
{
    public class TokenViewModel
    {
        public required int CatalogoTokenId { get; set; }

        public required string StringifiedToken { get; set; }

        public bool Expirable { get; set; } = false;

        public int? SegundosExpira { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
