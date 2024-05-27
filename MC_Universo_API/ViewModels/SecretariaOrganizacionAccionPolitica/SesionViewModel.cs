using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class SesionViewModel
    {
        public required int TipoSesionId { get; set; }

        public required int EntidadFederativaId { get; set; }


        public required int UsuarioId { get; set; }

        public required string Direccion { get; set; }

        public string? Comentarios { get; set; }

        public DateTime FechaSesion { get; set; } = DateTime.UtcNow;


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
