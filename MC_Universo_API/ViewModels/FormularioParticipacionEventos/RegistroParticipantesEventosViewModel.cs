using MC_Universo_API.Models.FormularioParticipacionEventos;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.ViewModels.FormularioParticipacionEventos
{
    public class RegistroParticipantesEventosViewModel
    {
        public required string Nombre { get; set; }

        public required string Apellidos { get; set; }

        public required int Edad { get; set; }

        public required int GeneroId { get; set; }

        public required string CorreoElectronico { get; set; }

        public required string Celular { get; set; }

        public bool ParticiparEnActividades { get; set; }

        public bool MovimientoEnColonia { get; set; }

        public bool RepresentanteDeCasilla { get; set; }

        public bool ExperienciaPrevia { get; set; }

        public bool AfiliarseAMovimientoCiudadano { get; set; }

        public bool ColocarPublicidadEnDomicilio { get; set; }

        public bool AceptoTerminosCondiciones { get; set; } = true;

        public bool AceptoMantenermeInformado { get; set; }

        public required string NombreEvento { get; set; }

        public required string OrganizadorEvento { get; set; }

        public required string LugarEvento { get; set; }
        
        public int EntidadfederativaEventoId { get; set; }

        public DateTime FechaEvento { get; set; }
        
        public string? Folio { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;
        

    }
}
