using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class CatalogoTipoSesion_Seed
    {
        public readonly List<CatalogoTipoSesion> CatalogosTipoSesion = new()
        {
            new CatalogoTipoSesion {Id = 1, Nombre = "Consejo estatal"},
            new CatalogoTipoSesion {Id = 2, Nombre = "Comisión operativa estatal"},
            new CatalogoTipoSesion {Id = 3, Nombre = "Junta de coordinación"},
            new CatalogoTipoSesion {Id = 4, Nombre = "Coordinadora"},
        };
    }
}
