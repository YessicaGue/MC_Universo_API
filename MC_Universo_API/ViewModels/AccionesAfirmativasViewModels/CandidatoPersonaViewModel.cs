using MC_Universo_API.Controllers;

namespace MC_Universo_API.ViewModels.AccionesAfirmativas;

public class CandidatoPersonaViewModel
{
    //persona
    public required string Nombre { get; set; }

    public required string ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; } = default!;
    
    public DateTime? FechaNacimiento { get; set; }
    
    public required int GeneroId { get; set; }

    public string? ClaveElector { get; set; }

    public required string Curp { get; set; }

    //candidato

    public string? NumeroLista { get; set; }

    public required int EstadoId { get; set; }
    
    public int? DistritoId { get; set; }

    public bool IdentificacionIndigena { get; set; }

    public required bool Afromexicanas { get; set; }

    public required bool ConDiscapacidad { get; set; }

    public required bool PersonaJoven { get; set; }

    public required bool DiversidadSexual { get; set; }

    public required bool MexicanosMigrantes { get; set; }

    public required bool PersonaAdultoMayor { get; set; }

    public bool? EnPobreza { get; set; }

    public required int RepresentanteId { get; set; }

    public required bool DatoDePrueba { get; set; } = false;

    public required bool EsSuplente { get; set; } = false;

    public bool EsAccionesAfirmativas { get; set; } = true;
}