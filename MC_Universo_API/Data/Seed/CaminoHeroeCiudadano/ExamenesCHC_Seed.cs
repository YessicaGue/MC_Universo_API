using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class ExamenesCHC_Seed
    {
        public readonly List<ExamenesCHC> ExamenesCHC = new()
        {
            new ExamenesCHC {Id=1, NombreExamen = "Evaluación sobre la Carta de Bienvenida",Activo=true,FechaAlta =DateTime.UtcNow},
            new ExamenesCHC {Id=2, NombreExamen = "Evaluación carta compromiso",Activo=true,FechaAlta =DateTime.UtcNow},
            new ExamenesCHC {Id=3, NombreExamen = "Evaluación valores",Activo=true,FechaAlta =DateTime.UtcNow},
        };
    }
}
