using MC_Universo_API.Models.CirculosCiudadanos;

namespace MC_Universo_API.Data.Seed.CirculosCiudadanos;

public class CatalogoCheckInsCedulaCirculo_Seed
{
    public readonly List<CatalogoCheckInsCedulaCirculo> CatalogosCheckInsCedulaCirculo =
    [
        new CatalogoCheckInsCedulaCirculo
        {
            Id = 1,
            Nombre =
                "Por mi libre voluntad solicito mi afiliación a Movimiento Ciudadano y apoyar las actividades que realicen."
        },

        new CatalogoCheckInsCedulaCirculo
        {
            Id = 2,
            Nombre =
                "Me gustaría integrar un Círculo Ciudadano y apoyar con familiares, amigos y vecinos las actividades de Movimiento Ciudadano."
        },

        new CatalogoCheckInsCedulaCirculo
        {
            Id = 3,
            Nombre =
                "Me gustaría recibir información de las actividades que realizan, simpatizo con Movimiento Ciudadano."
        },

        new CatalogoCheckInsCedulaCirculo
            { Id = 4, Nombre = "Me gustaría ser candidato (a) ó representante de Movimiento Ciudadano." }

    ];
}