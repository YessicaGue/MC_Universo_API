using MC_Universo_API.Models;
using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class CatalogoCaminosCHC_Seed
    {
        public readonly List<CatalogoCaminosCHC> CatalogosCaminosCHC = new()
        {
            new CatalogoCaminosCHC {Id = 1, Nombre = "General", NombreColor = "Naranja"},
            new CatalogoCaminosCHC {Id = 2, Nombre = "Mujeres", NombreColor = "Violeta"},
            new CatalogoCaminosCHC {Id = 3, Nombre = "Jóvenes", NombreColor = "Fosfo"},
            new CatalogoCaminosCHC {Id = 4, Nombre = "Ciudadano", NombreColor = "Blanco"},
            new CatalogoCaminosCHC {Id = 5, Nombre = "Personas con discapacidad", NombreColor = "Eléctrico"},
            new CatalogoCaminosCHC {Id = 6, Nombre = "Pueblos originarios", NombreColor = "Celeste"},
            new CatalogoCaminosCHC {Id = 7, Nombre = "Afrodescendientes", NombreColor = "Limón"},
            new CatalogoCaminosCHC {Id = 8, Nombre = "LGBTTTIQ", NombreColor = "Arcoíris"},
            new CatalogoCaminosCHC {Id = 9, Nombre = "Combinado", NombreColor = "Tornasol"}
        };
    }
}
