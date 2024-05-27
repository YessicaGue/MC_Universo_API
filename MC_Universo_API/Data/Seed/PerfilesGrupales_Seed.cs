using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed
{
    public class PerfilesGrupales_Seed
    {
        public readonly List<PerfilGrupal> PerfilGrupal = new()
        {
            new PerfilGrupal {Id = 1, Guid = new Guid("5d3e0abe-ef5a-4848-90ba-5adfaba23002"), Alias = "Jóvenes en movimiento",         Frase = "La unión hace cambios", Foto = "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", Activo = true,Url = "jovenes-en-movimiento", esPublico = true, UrlVideoPrincipal="https://www.youtube.com/embed/Cd_S6YQtBqk",FechaCreacion = DateTime.UtcNow },
            new PerfilGrupal {Id = 2, Guid = new Guid("65fb3612-7866-44d1-9126-efc72ca2dda7"), Alias = "Mujeres en Movimiento",         Frase = "Por una participación afectiva",Foto = "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg",Activo = true, Url = "mujeres-en-movimiento",  esPublico = true, UrlVideoPrincipal="https://www.youtube.com/embed/Cd_S6YQtBqk", FechaCreacion = DateTime.UtcNow},
            new PerfilGrupal {Id = 3, Guid = new Guid("4e298068-e6f0-439b-ad45-888342daa9d4"), Alias = "Fundación México con Valores",  Frase = "Ciudadanos comprometidos", Foto = "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", Activo = true, Url = "fundacion-mexico-valores", esPublico = true, UrlVideoPrincipal="https://www.youtube.com/embed/Cd_S6YQtBqk", FechaCreacion = DateTime.UtcNow},
            new PerfilGrupal {Id = 4, Guid = new Guid("e021dc57-3195-4a74-9f58-6297cb91fa18"), Alias = "Mercadito Naranja",             Frase = "Mercadito Naranja" , Foto = "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", Activo = true, Url = "mercadito-naranja" , esPublico = true, UrlVideoPrincipal="https://www.youtube.com/embed/Cd_S6YQtBqk", FechaCreacion = DateTime.UtcNow},
            new PerfilGrupal {Id = 5, Guid = new Guid("05474085-5a72-4d8e-869e-8be96adafaf8"), Alias = "LabMC",                         Frase = "LabMC", Foto = "group_profile_pictures/aJHsgP8cftCAYEpWUDToyrgT1ee3xoANpq8XaUU2.jpg", Activo = true,Url = "lab-mc" , esPublico = true,UrlVideoPrincipal="https://www.youtube.com/embed/Cd_S6YQtBqk", FechaCreacion = DateTime.UtcNow}
        };
    }
}
