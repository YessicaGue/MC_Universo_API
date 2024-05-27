using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class Persona_Seed
{
    public readonly List<Persona> Personas = new()
    {
        new Persona {Id = 1, Nombre = "Jose Alfonso", ApellidoPaterno = "Gomez", ApellidoMaterno = "Coeto", Seudonimo = "Coeto", FechaNacimiento = DateTime.Parse("1994-07-24T22:00:00Z").ToUniversalTime(), EntidadFederativaId = 1,GeneroId = 1,CorreoElectronico = "coeto@gmail.com",TiempoResidencia = 1, TelefonoParticular = "+525555555555"},
        new Persona {Id = 2, Nombre = "Admin", ApellidoPaterno = "Naranja", ApellidoMaterno = null,Seudonimo = "Naranja",FechaNacimiento = DateTime.Parse("2000-01-01T22:00:00Z").ToUniversalTime(),EntidadFederativaId = 1,GeneroId = 1,CorreoElectronico = "naranja@gmail.com",TiempoResidencia = 2,TelefonoParticular = "+529999999999"},
    };
}