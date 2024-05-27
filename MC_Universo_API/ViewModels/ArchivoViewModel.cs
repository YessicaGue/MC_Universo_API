namespace MC_Universo_API.ViewModels
{
    public class ArchivoViewModel
    {
        public required string Nombre { get; set; }

        public required string Tipo { get; set; }

        public required string Directorio { get; set; }

        public string? Slug { get; set; }

        public bool Activo { get; set; } = true;

        public bool esPublico { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
