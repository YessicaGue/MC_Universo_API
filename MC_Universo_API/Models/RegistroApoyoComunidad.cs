using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models
{
    public class RegistroApoyoComunidad
    {
        [Key] // Atributo para indicar que esta propiedad es la clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Atributo para indicar que el valor de esta propiedad se genera automáticamente en la base de datos
        public int Id { get; init; }// // Propiedad "Id" de tipo entero que representa la clave primaria de la entidad

        public required int EntidadFederativaId { get; set; } // Propiedad que representa el ID de la entidad federativa
        [ForeignKey("EntidadFederativaId")]  // Atributo que indica que la propiedad "EntidadFederativa" está relacionada con la propiedad "EntidadFederativaId"
        public virtual EntidadFederativa EntidadFederativa { get; set; } = default!; // Propiedad de navegación que representa la entidad federativa relacionada

        public required string NombreCompleto { get; set; }

        public required string Email { get; set; }
        
        public int? NumeroWhatsapp { get; set; }
        
        public required DateTime FechaNacimiento{ get; set; }


    }
}
