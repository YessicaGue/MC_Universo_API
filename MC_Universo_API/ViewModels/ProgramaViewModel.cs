using Newtonsoft.Json;

namespace MC_Universo_API.ViewModels
{
    public class ProgramaViewModel
    {
        public required string Nombre { get; set; }

        public required string Localidad { get; set; }

        public required string Descripcion { get; set; }

        public bool? Activo { get; set; }

        public required int CantidadCupo { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }
    }
}
