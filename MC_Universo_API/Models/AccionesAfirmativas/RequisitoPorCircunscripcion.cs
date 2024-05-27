using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.AccionesAfirmativas
{
    public class RequisitoPorCircunscripcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int CicunscripcionId { get; set; }
        [ForeignKey("CicunscripcionId")]
        public virtual CatalogoCircunscripcion Cicunscripcion { get; set; } = default!;
        
        public required int RepresentanteId { get; set; }
        [ForeignKey("RepresentanteId")]
        public virtual CatalogoRepresentante CatalogoRepresentante { get; set; } = default!;

        public int LugaresDisponibles { get; set; }

        public int CantidadMujeres
        {
            get
            {
                if (LugaresDisponibles>0)
                {
                    if (LugaresDisponibles == 1)
                    {
                        return 1;

                    }
                    else
                    {
                        int candidatos = LugaresDisponibles;
                        return candidatos % 2 == 0 ? candidatos / 2 : (candidatos / 2) + 1;
                    }
                }
                return 0;
            }
        }


        public int CantidadIdentificacionIndigena { get; set; }

        public int CantidadMigrantes { get; set; }

        public int AnioEleccion { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set;} = true;    

    }
}
