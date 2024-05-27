using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoOchoAcciones_Seed
    {
        public readonly List<CatalogoOchoAcciones> CatalogosOchoAcciones = new()
        {
            new CatalogoOchoAcciones {Id = 1,  Nombre = "El movimiento escucha"},
            new CatalogoOchoAcciones {Id = 2,  Nombre = "La quincena"},
            new CatalogoOchoAcciones {Id = 3,  Nombre = "Picnic naranja"},
            new CatalogoOchoAcciones {Id = 4,  Nombre = "Pinta el futuro"},
            new CatalogoOchoAcciones {Id = 5,  Nombre = "Escuela naranja"},
            new CatalogoOchoAcciones {Id = 6,  Nombre = "Barrio naranja"},
            new CatalogoOchoAcciones {Id = 7,  Nombre = "Mercadito naranja"},
            new CatalogoOchoAcciones {Id = 8,  Nombre = "Casas naranjas"}
        };
    }
}
