namespace MC_Universo_API.ViewModels
{
    public class VoluntarioProgramaViewModel
    {
        public required int VoluntarioId { get; set; }

        public required int ProgramaId { get; set; }

        public bool? Activo { get; set; } = true;
    }
}
