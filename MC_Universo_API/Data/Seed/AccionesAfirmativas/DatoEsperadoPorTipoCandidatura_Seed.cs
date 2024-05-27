using MC_Universo_API.Models.AccionesAfirmativas;
using System.Globalization;

namespace MC_Universo_API.Data.Seed.AccionesAfirmativas
{
    public class DatoEsperadoPorTipoCandidatura_Seed
    {
        public readonly List<DatosEsperadosPorTipoCandidatura> DatoEsperadoPorTipoCandidatura = new()
        {
            new DatosEsperadosPorTipoCandidatura{
                Id=1,
                CatalogoRepresentanteId=1,
                CandidatosTotales = 200,
                CantidadAdscripcionIndigena =11,
                CantidadDiversidadSexual=2,
                CantidadAfromexicanos = 1,
                CantidadDiscapacitados=1,
                CantidadPersonaMigrante= 5,
                CantidadPersonaMayor= 0,
                CantidadPersonaJoven= 0,
                AnioElecciones=2024,
                FechaCreacion = DateTime.UtcNow
            },
            new DatosEsperadosPorTipoCandidatura{
                Id=2,
                CatalogoRepresentanteId=2,
                CandidatosTotales = 300,
                CantidadAdscripcionIndigena = 18,
                CantidadDiversidadSexual= 2,
                CantidadAfromexicanos = 3,
                CantidadDiscapacitados= 6,
                CantidadPersonaMigrante= 0,
                CantidadPersonaMayor= 0,
                CantidadPersonaJoven= 0,
                AnioElecciones=2024,
                FechaCreacion = DateTime.UtcNow
            },
            new DatosEsperadosPorTipoCandidatura{
                Id=3,
                CatalogoRepresentanteId=3,
                CandidatosTotales = 32,
                CantidadMujeres = 16,
                CantidadHombres = 16,
                CantidadAdscripcionIndigena = 5,
                CantidadDiversidadSexual = 1,
                CantidadAfromexicanos = 1,
                CantidadDiscapacitados = 1,
                CantidadPersonaMigrante = 0 ,
                CantidadPersonaMayor = 0,
                CantidadPersonaJoven= 0,
                AnioElecciones=2024,
                FechaCreacion = DateTime.UtcNow
            },
            new DatosEsperadosPorTipoCandidatura{
                Id=4,
                CatalogoRepresentanteId=4,
                CantidadAdscripcionIndigena = 5,
                CandidatosTotales = 64,
                CantidadMujeres = 32,
                CantidadHombres = 32,
                CantidadDiversidadSexual= 1,
                CantidadAfromexicanos = 1,
                CantidadDiscapacitados= 1,
                CantidadPersonaMigrante= 0,
                CantidadPersonaMayor= 0,
                CantidadPersonaJoven= 0,
                AnioElecciones=2024,
                FechaCreacion = DateTime.UtcNow
            },
            new DatosEsperadosPorTipoCandidatura{
                Id=5,
                CatalogoRepresentanteId=5,
                CantidadAdscripcionIndigena = 0,
                CantidadDiversidadSexual= 0,
                CantidadAfromexicanos = 0,
                CantidadDiscapacitados= 0,
                CantidadPersonaMigrante= 0,
                CantidadPersonaMayor= 0,
                CantidadPersonaJoven= 0,
                AnioElecciones=2024,
                FechaCreacion = DateTime.UtcNow
            },
        };
    }
}
