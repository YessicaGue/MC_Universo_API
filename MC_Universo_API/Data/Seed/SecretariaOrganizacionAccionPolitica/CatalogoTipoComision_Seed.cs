using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class CatalogoTipoComision_Seed
    {
        public readonly List<CatalogoTipoComision> CatalogosTipoComision = new()
        {
            new CatalogoTipoComision {Id = 1, Nombre = "Electa"},
            new CatalogoTipoComision {Id = 2, Nombre = "Provisional"},
        };
    }
}
