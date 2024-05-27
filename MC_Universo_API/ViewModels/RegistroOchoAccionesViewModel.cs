namespace MC_Universo_API.ViewModels
{
    public class RegistroOchoAccionesViewModel
    {
        public required int GeneroId { get; set; }

        public int? EscolaridadId { get; set; }

        public int? MotivoId { get; set; }

        public required int EntidadFederativaId { get; set; }

        public required int EstatusRegistroId { get; set; }

        public required string Nombre { get; set; }

        public required string ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public required string Direccion { get; set; }

        public required DateTime FechaNacimiento { get; set; }
    }
}
