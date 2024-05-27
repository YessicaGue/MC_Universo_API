namespace MC_Universo_API.ViewModels
{
    public class PerfilViewModel
    {
        public Guid Guid { get; set; } = Guid.NewGuid();

        public string? Alias { get; set; }

        public string? Descripcion { get; set; }

        public bool Activo { get; set; } = true;

        public required string Url { get; set; }

        public string? CustomUrl { get; set; }

        public bool esPublico { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
