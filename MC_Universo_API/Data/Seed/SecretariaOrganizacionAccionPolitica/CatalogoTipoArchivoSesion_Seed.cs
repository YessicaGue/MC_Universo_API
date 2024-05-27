using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class CatalogoTipoArchivoSesion_Seed
    {
        public readonly List<CatalogoTipoArchivoSesion> CatalogosTipoArchivoSesion = new()
        {
            new CatalogoTipoArchivoSesion {Id = 1, Nombre = "Foto/Imagen"},
            new CatalogoTipoArchivoSesion {Id = 2, Nombre = "Acta"},
            new CatalogoTipoArchivoSesion {Id = 3, Nombre = "Lista"},
        };
    }
}
