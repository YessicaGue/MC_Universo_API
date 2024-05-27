using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MC_Universo_API.Models.AccionesAfirmativas;

public class DistritosFederales
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
    public int Id { get; init; }
    
    public required int CircunscripcionId { get; set; }
    [ForeignKey("CircunscripcionId")]
    public virtual CatalogoCircunscripcion CatalogoCircunscripcion { get; set; } = default!; 
    
    public required int EntidadId { get; set; }
    [ForeignKey("EntidadId")] 
    public virtual EntidadFederativa EntidadFederativa { get; set; } = default!;

    public required string CabeceraDistrital { get; set; }

    public required int Distrito { get; set; }
    
    public required string Nombre { get; set; }
    
    public string? BloqueConcentracionIndigena { get; set; }
    
    public string? McCompetitividad { get;set; }
    
    
    public double? McPorcentaje { get; set; }

    public bool SiIndigenaMcAltoMr
    {
        get
        {
            return BloqueConcentracionIndigena == "ALTA" && McCompetitividad == "ALTA";
        }
    }

    public bool SiIndigenaMcMedioMr
    {
        get
        {
            return BloqueConcentracionIndigena == "ALTA" && McCompetitividad == "MEDIA";
        }
    }
    
    public bool SiIndigenaMcBajoMr
    {
        get
        {
            return BloqueConcentracionIndigena == "ALTA" && McCompetitividad == "BAJA";
        }
    }
    
    public int? AnioEleccion { get; set; }
    
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    
    public bool Activo { get; set; } = true;
}