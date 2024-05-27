using MC_Universo_API.Models;
using MC_Universo_API.ViewModels;

namespace MC_Universo_API.Data.Seed
{
    public class CatalogoPreguntasEncuestas_Seed
    {
        public readonly List<CatalogoPreguntasEncuestas> CatalogosPreguntasEncuestas = new()
        {
            new CatalogoPreguntasEncuestas {Id = 1, Nombre = "Platícanos tus necesidades de capacitación o certifícate con CONOCER", CategoriaPreguntaId = 1},
            new CatalogoPreguntasEncuestas {Id = 2, Nombre = "Dentro de tus conocimientos profesionales, ¿Te gustaría desarrollar algún curso?", CategoriaPreguntaId = 1},
        };
    }
}
