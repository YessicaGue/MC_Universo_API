using MC_Universo_API.Models.AccionesAfirmativas;

namespace MC_Universo_API.Data.Seed.AccionesAfirmativas
{
    public class RequisitoPorCircunscripcion_Seed
    {
        public readonly List<RequisitoPorCircunscripcion> RequisitoPorCircunscripcion = new()
        {
            new RequisitoPorCircunscripcion{ Id=1, CicunscripcionId = 1, RepresentanteId = 1, LugaresDisponibles = 40, CantidadIdentificacionIndigena =  1, CantidadMigrantes = 1 ,AnioEleccion = 2024 },
            new RequisitoPorCircunscripcion{ Id=2, CicunscripcionId = 2, RepresentanteId = 1, LugaresDisponibles = 40, CantidadIdentificacionIndigena =  1, CantidadMigrantes = 1 ,AnioEleccion = 2024 },
            new RequisitoPorCircunscripcion{ Id=3, CicunscripcionId = 3, RepresentanteId = 1, LugaresDisponibles = 40, CantidadIdentificacionIndigena =  4, CantidadMigrantes = 1 ,AnioEleccion = 2024 },
            new RequisitoPorCircunscripcion{ Id=4, CicunscripcionId = 4, RepresentanteId = 1, LugaresDisponibles = 40, CantidadIdentificacionIndigena =  2, CantidadMigrantes = 1 ,AnioEleccion = 2024 },
            new RequisitoPorCircunscripcion{ Id=5, CicunscripcionId = 5, RepresentanteId = 1, LugaresDisponibles = 40, CantidadIdentificacionIndigena =  1, CantidadMigrantes = 1 ,AnioEleccion = 2024 },
        };
    }
}
