using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class CatalogoRolComision_Seed
    {
        public readonly List<CatalogoRolComision> CatalogosRolComision = new()
        {
            new CatalogoRolComision {Id = 1, Nombre = "Coordinador"},
        };
    }
}
