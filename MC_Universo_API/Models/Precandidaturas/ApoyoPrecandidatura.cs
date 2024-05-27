using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.Precandidaturas
{
    public class ApoyoPrecandidatura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilId { get; set; }
        [ForeignKey("PerfilId")] public virtual Perfil Perfil { get; set; } = default!;

        public required int TipoPrecandidaturaId { get; set; }
        [ForeignKey("TipoPrecandidaturaId")]
        public virtual CatalogoTipoPrecandidatura CatalogoTipoPrecandidatura { get; set; } = default!;

        public string? Email { get; set; }

        public string? NumeroTelefono { get; set; }

        [Length(maximumLength: 18, minimumLength: 18)]
        public string? ClaveElector { get; set; }

        [Comment("Esta columna guarda el formulario llenado en formato JSON")]
        public required string FormularioRellenadoJSON { get; set; }

        [Comment("Esta columna indica si el registro esta interesado en recibir mas informacion")]
        public bool? EstaInteresadoInformacionAdicional { get; set; }

        public bool? ConfirmacionRegistro { get; set; }

        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}