using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class ComisionUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }


        public required int ComisionId { get; set; }
        [ForeignKey("ComisionId")]
        public virtual Comision Comision { get; set; } = default!;

        public required int RolComisionId { get; set; }
        [ForeignKey("RolComisionId")]
        public virtual CatalogoRolComision CatalogoRolComision { get; set; } = default!;


        [Comment("Id del usuario dashboard relacionado a la comision")]
        public required int UsuarioId { get; set; }


        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}
