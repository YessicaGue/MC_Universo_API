using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.Utils;

namespace MC_Universo_API.Data.Seed.AccionesAfirmativas;

public class CatalogoCircunscripcion_Seed
{
    public readonly List<CatalogoCircunscripcion> CatalogoCircunscripcion = new()
    {
      new CatalogoCircunscripcion{Id = 1, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), Circunscripcion = 1, Nombre = "Circunscripcion 1"},
      new CatalogoCircunscripcion{Id = 2, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), Circunscripcion = 2, Nombre = "Circunscripcion 2"},
      new CatalogoCircunscripcion{Id = 3, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), Circunscripcion = 3, Nombre = "Circunscripcion 3"},
      new CatalogoCircunscripcion{Id = 4, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), Circunscripcion = 4, Nombre = "Circunscripcion 4"},
      new CatalogoCircunscripcion{Id = 5, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), Circunscripcion = 5, Nombre = "Circunscripcion 5"},
    };
}