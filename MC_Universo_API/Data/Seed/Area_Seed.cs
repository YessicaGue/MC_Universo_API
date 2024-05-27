using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class Area_Seed
    {
        public readonly List<Area> Areas = new()
        {
            new Area {Id = 1, Nombre = "Jóvenes"},
            new Area {Id = 2, Nombre = "Mujeres"},
        };
    }
}
