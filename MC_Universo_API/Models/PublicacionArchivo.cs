using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models
{
    public class PublicacionArchivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; init; }

        public required int PublicacionId { get; set; }
        [ForeignKey("PublicacionId")]
        public virtual Publicacion Publicacion { get; set; } = default!;

        public required int ArchivoId { get; set; }
        [ForeignKey("ArchivoId")]
        public virtual Archivo Archivo { get; set; } = default!;
    }
}
