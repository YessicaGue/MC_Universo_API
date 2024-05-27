namespace MC_Universo_API.ViewModels
{
    public class PerfilGrupalViewModel
    {
        public Guid Guid { get; set; } = Guid.NewGuid();

        public string? Alias { get; set; }

        public string? Frase { get; set; }

        public string? Foto { get; set; } 

        public string? FotoPortada { get; set; }

        public bool Activo { get; set; } = true;

        public required string Url { get; set; }

        public string? CustomUrl { get; set; }

        public bool esPublico { get; set; } = true;

        public string? UrlVideoPrincipal { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
