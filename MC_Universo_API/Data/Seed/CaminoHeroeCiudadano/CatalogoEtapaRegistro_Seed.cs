using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano;

public class CatalogoEtapaRegistroCHC_Seed
{
    public readonly List<CatalogoEtapaRegistroCHC> CatalogoEtapaRegistroCHC = new()
    {
        new CatalogoEtapaRegistroCHC
        {
            Id = 1, Nombre = "Requisitos Ciudadanos", Descripcion = null, NombreURLRoute = "camino.candidato.page",
            IndiceOrden = 1, Activo = true, FechaAlta = DateTime.UtcNow
        },
        new CatalogoEtapaRegistroCHC
        {
            //no es necesario validacion 
            Id = 2, Nombre = "Bienvenida 2", Descripcion = null,NombreURLRoute = "heroe.ciudadano.page" ,
            IndiceOrden = 2, Activo = true, FechaAlta = DateTime.UtcNow
        },
        new CatalogoEtapaRegistroCHC
        {
            Id = 3 , Nombre = "Carta Compromiso",Descripcion = null, NombreURLRoute = "carta.compromiso.page",
            IndiceOrden = 3, Activo = true, FechaAlta = DateTime.UtcNow
        },
        new CatalogoEtapaRegistroCHC
        {
            Id = 4,Nombre = "Valores y Principios",Descripcion = null, NombreURLRoute = "elegibilidad.page",
            IndiceOrden = 4, Activo = true, FechaAlta = DateTime.UtcNow
        }
    };
}