namespace MC_Universo_API.ViewModels
{
    public class PerfilGrupalCatalogoRedesSocialesViewModel
    {
        public required int CatalogoRedesSocialesId { get; set; }

        public required int PerfilGrupalId { get; set; }

        public String? Url { get; set; }

        public bool Activo { get; set; } = true;

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    }
}
