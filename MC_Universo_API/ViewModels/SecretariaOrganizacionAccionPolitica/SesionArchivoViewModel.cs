using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class SesionArchivoViewModel
    {
        public required int SesionId { get; set; }

        public required int ArchivoId { get; set; }

        public required int EstadoValidacionArchivoId { get; set; }


        public required int UsuarioValidacionArchivoId { get; set; }

        public required int UsuarioCargaId { get; set; }


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
