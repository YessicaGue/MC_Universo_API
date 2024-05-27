using MC_Universo_API.ViewModels.TemasInteresesLading;
using MC_Universo_API.Models;

namespace MC_Universo_API.ViewModels.TemasInteresesLading;

public class ContenedorFormularioTemasInteresesCausasLandingViewModel
{
    public FormularioTemasInteresViewModel FormularioTemasInteresViewModel { get; set; }

    public List<CatalogoCausasLandingViewModel> CatalogoCausasLandingViewModels { get; set; }
}