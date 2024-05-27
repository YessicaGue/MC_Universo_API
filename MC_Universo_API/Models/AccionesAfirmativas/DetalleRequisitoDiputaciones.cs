using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MC_Universo_API.Models.AccionesAfirmativas;

public class DetalleRequisitoDiputaciones
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public required int EstadoCircunscripcionId { get; set; }
    [ForeignKey("EstadoCircunscripcionId")] 
    public virtual EstadoCircunscripcion EstadoCircunscripcion  { get; set; } = default!;
    
    public int CandidatosDiputadosMayoriaRelativa { get; set; }

    public int MujeresDiputadosMayoriaRelativa
    {
        get
        {
            if (CandidatosDiputadosMayoriaRelativa >= 0)
            {
                if(CandidatosDiputadosMayoriaRelativa == 1)
                {
                    return 1;

                } else {
                    int candidatos = CandidatosDiputadosMayoriaRelativa;
                    return candidatos % 2 == 0 ? candidatos / 2 : (candidatos / 2) + 1;
                }
            }
            return 0;
        }
    }

    public int FormulasMayoriaRelativa { get; set; }
    
    public int CandidatosDiputadosRepresentacionProporcional { get; set; }

    public int MujeresDiputadosRepresentacionProporcional
    {
        get
        {
            if (CandidatosDiputadosRepresentacionProporcional>=0)
            {
                if (CandidatosDiputadosRepresentacionProporcional == 1)
                {
                    return 1;

                }
                else
                {
                    int candidatos = CandidatosDiputadosRepresentacionProporcional;
                    return candidatos % 2 == 0 ? candidatos / 2 : (candidatos / 2) + 1;
                }
            }
            return 0;
        }
    }
    
    public int FormulasRepresentacionProporcional { get; set; }


    public int CandidatosSenadorMayoriaRelativa { get; set; }


    public int MujeresSenadorMayoriaRelativa
    {
        get
        {
            if (CandidatosSenadorMayoriaRelativa>0)
            {
                if (CandidatosSenadorMayoriaRelativa == 1)
                {
                    return 1;

                }
                else
                {
                    int candidatos = CandidatosSenadorMayoriaRelativa;
                    return candidatos % 2 == 0 ? candidatos / 2 : (candidatos / 2) + 1;
                }
            }
            return 0;
        }

    }


    public int CandidatosSenadorPrimeraMinoria { get; set; }


    public int CandidatosSenadorRepresentacionProporcional { get; set; }

    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

    public bool Activo { get; set; } = true;
}