namespace MC_Universo_API.ViewModels
{
    public class CatalogoPublicacionesPerfilGrupalViewModel
    {
        public required string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
