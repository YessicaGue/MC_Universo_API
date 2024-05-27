using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class DatoContacto_Seed
{
    public readonly List<DatoContacto> DatoContactos = new()
    {
        new DatoContacto { Id = 1, Valor = "alfonso.coeto@guacamayotech.com", Verificado = true, PersonaId = 1, TipoContactoId = 1 },
        new DatoContacto { Id = 2, Valor = "admin@test.com", Verificado = true, PersonaId = 2, TipoContactoId = 1 }
    };
}