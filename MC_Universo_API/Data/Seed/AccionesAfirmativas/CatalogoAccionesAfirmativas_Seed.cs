using MC_Universo_API.Models.AccionesAfirmativas;

namespace MC_Universo_API.Data.Seed.AccionesAfirmativas
{
    public class CatalogoAccionesAfirmativas_Seed
    {
        public readonly List<CatalogoAccionesAfirmativas> CatalogoAccionesAfirmativas = new()
        {
            new CatalogoAccionesAfirmativas{Id =1, ShortId = new Utils.GeneradorShortId().GenerarCadenaAleatoria(), Nombre =" Personas Indígenas"},
            new CatalogoAccionesAfirmativas{Id =2, ShortId = new Utils.GeneradorShortId().GenerarCadenaAleatoria(), Nombre =" Personas Afromexicanas"},
            new CatalogoAccionesAfirmativas{Id =3, ShortId = new Utils.GeneradorShortId().GenerarCadenaAleatoria(), Nombre =" Personas con Discapacidad"},
            new CatalogoAccionesAfirmativas{Id =4, ShortId = new Utils.GeneradorShortId().GenerarCadenaAleatoria(), Nombre =" Personas Jóvenes"},
            new CatalogoAccionesAfirmativas{Id =5, ShortId = new Utils.GeneradorShortId().GenerarCadenaAleatoria(), Nombre =" Personas de la Diversidad Sexual"},
            new CatalogoAccionesAfirmativas{Id =6, ShortId = new Utils.GeneradorShortId().GenerarCadenaAleatoria(), Nombre =" Personas Migrantes y Residentes en el Extranjero"},
            new CatalogoAccionesAfirmativas{Id =7, ShortId = new Utils.GeneradorShortId().GenerarCadenaAleatoria(), Nombre =" Personas Adultas Mayores"},
        };
    }
}
