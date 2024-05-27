using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class ComisionViewModel
    {
        public required int TipoComisionId { get; set; }

        public required int EntidadFederativaId { get; set; }
        

        public DateTime FechaVigencia { get; set; } = DateTime.UtcNow;

        public required string Periodicidad { get; set; }


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
