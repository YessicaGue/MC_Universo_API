using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.Precandidaturas
{
    [Comment("Debido a que solo se puede registrar un tipo de precandidatura por perfil, se establece constraint unique")]
    [Index(nameof(PerfilId), IsUnique = true)]
    [Index(nameof(Telefono), IsUnique = true)]
    public class PerfilPrecandidatura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PerfilId { get; set; }
        [ForeignKey("PerfilId")] public virtual Perfil Perfil { get; set; } = default!;

        public required int TipoPrecandidaturaId { get; set; }
        [ForeignKey("TipoPrecandidaturaId")]
        public virtual CatalogoTipoPrecandidatura CatalogoTipoPrecandidatura { get; set; }

        public string? Descripcion { get; set; }

        public string? FotoPerfil { get; set; }
        
        public int? EntidadFederativaId { get; set; } = null;
        [ForeignKey("EntidadFederativaId")]
        public virtual EntidadFederativa? EntidadFederativa { get; set; }
        
        // Municipio/Distrito
        [MaxLength(200)]
        public string? Municipio { get; set; }
        
        public int? Distrito { get; set; }
        
        // Teléfono
        [MaxLength(10)]
        public string? Telefono { get; set; }
        
        // Dictaminado
        public bool Dictaminado { get; set; } = false;

        public Guid? GuidInvitacionCoadministracion { get; set; }
        public string? LigaInvitacionCoadministracion { get; set; }

        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaBaja { get; set; }
    }
}