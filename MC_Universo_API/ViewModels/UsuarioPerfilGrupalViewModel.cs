namespace MC_Universo_API.ViewModels
{
    public class UsuarioPerfilGrupalViewModel
    {
        public required int UsuarioId { get; set; }
        public required int PerfilGrupalId { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
