using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class RegistroOchoAccionesUsuarioCatalogoOchoAcciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int RegistroOchoAccionesUsuarioId { get; set; }
        [ForeignKey("RegistroOchoAccionesUsuarioId")]
        public virtual RegistroOchoAccionesUsuario RegistroOchoAccionesUsuario { get; set; } = default!;

        public required int CatalogoOchoAccionesId { get; set; }
        [ForeignKey("CatalogoOchoAccionesId")]
        public virtual CatalogoOchoAcciones CatalogoOchoAcciones { get; set; } = default!;
    }
}
