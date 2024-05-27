using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.Utils;

namespace MC_Universo_API.Data.Seed.AccionesAfirmativas;

public class CatalogoRepresentante_Seed
{
    public readonly List<CatalogoRepresentante> CatalogoRepresentante = new()
    {
        new CatalogoRepresentante{Id = 1, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), NombreCargo = "Diputación", Principio = "Representación Proporcional", NivelCargo = "Federal"},
        new CatalogoRepresentante{Id = 2, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), NombreCargo = "Diputación", Principio = "Mayoría Relativa", NivelCargo = "Federal"},
        new CatalogoRepresentante{Id = 3, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), NombreCargo = "Senaduría", Principio = "Representación Proporcional", NivelCargo = "Federal"},
        new CatalogoRepresentante{Id = 4, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), NombreCargo = "Senaduría", Principio = "Mayoría Relativa",NivelCargo = "Federal"},
        new CatalogoRepresentante{Id = 5, ShortId = new GeneradorShortId().GenerarCadenaAleatoria(), NombreCargo = "Senaduría", Principio = "Primera Minoria",NivelCargo = "Federal"},
    };
} 