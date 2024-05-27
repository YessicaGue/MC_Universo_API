using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoCausasLanding_Seed
    {
        public readonly List<CatalogoCausasLanding> CatalogosCausasLanding = new()
        {
            new CatalogoCausasLanding {Id = 1,  Nombre = "Mujeres" },
            new CatalogoCausasLanding {Id = 2,  Nombre = "Jóvenes" },
            new CatalogoCausasLanding {Id = 3,  Nombre = "Medio ambiente" },
            new CatalogoCausasLanding {Id = 4,  Nombre = "Personas con discapacidad" },
            new CatalogoCausasLanding {Id = 5,  Nombre = "Derechos humanos" },
            new CatalogoCausasLanding {Id = 6,  Nombre = "Trabajo" },
            new CatalogoCausasLanding {Id = 7,  Nombre = "El campo" },
        };
    }
}
