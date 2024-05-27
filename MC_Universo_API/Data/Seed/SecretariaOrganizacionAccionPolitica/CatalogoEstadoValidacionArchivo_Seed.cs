using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica
{
    public class CatalogoEstadoValidacionArchivo_Seed
    {
        public readonly List<CatalogoEstadoValidacionArchivo> CatalogosEstadoValidacionArchivo = new()
        {
            new CatalogoEstadoValidacionArchivo {Id = 1, Nombre = "En proceso"},
            new CatalogoEstadoValidacionArchivo {Id = 2, Nombre = "Comentado"},
            new CatalogoEstadoValidacionArchivo {Id = 3, Nombre = "Aceptado"},
        };
    }
}
