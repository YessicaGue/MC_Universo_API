using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class PreguntasExamenCHC_Seed
    {
        public readonly List<PreguntasExamenCHC> PreguntasExamenCHC = new()
        {
            new PreguntasExamenCHC{Id=1, ExamenCHCId=1,TipoPreguntaId=1, Pregunta="¿Cuál es el objetivo del camino del héroe ciudadan@?",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=2, ExamenCHCId=1,TipoPreguntaId=1, Pregunta="¿Por qué hay varios caminos al héroe ciudadano?",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=3, ExamenCHCId=1,TipoPreguntaId=1, Pregunta="¿Si participas en el Camino del Héroe Ciudadano tienes asegurada una candidatura de Movimiento Ciudadano?",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=4, ExamenCHCId=2,TipoPreguntaId=1, Pregunta="¿Si registro mi información en la plataforma del Camino del Héroe Ciudadano ya no tengo que registrar mi información ante el INE?",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=5, ExamenCHCId=2,TipoPreguntaId=1, Pregunta="¿Puedo participar en varios caminos para ser considerado en varios procesos de selección de precandidaturas si cumplo con los requisitos de acceso?",Activo=true,FechaAlta=DateTime.UtcNow},
            //Preguntas Valores Principios
            new PreguntasExamenCHC{Id=6, ExamenCHCId=3,TipoPreguntaId=1, Pregunta="¿Qué está prohibido por la ley 3 de 3 y hace que una persona no pueda participar en el camino del héroe y la heroína ciudadana?",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=7, ExamenCHCId=3,TipoPreguntaId=1, Pregunta="¿En cuáles documentos se encuentran los valores, propuestas y principios de Movimiento Ciudadano que todas las personas participantes del camino del héroe y la heroína ciudadana deben seguir?",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=8, ExamenCHCId=3,TipoPreguntaId=1, Pregunta="¿El camino del héroe y la heroína ciudadana se  encuentra  vinculado  con  las  convocatorias  de  la  Comisión  Nacional  de  Convenciones  y  Procesos  Internos  de  Movimiento  Ciudadano?",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=9, ExamenCHCId=3,TipoPreguntaId=1, Pregunta="Selecciona la respuesta que incluye algunos de los principios que Movimiento Ciudadano respalda:",Activo=true,FechaAlta=DateTime.UtcNow},
            new PreguntasExamenCHC{Id=10, ExamenCHCId=3,TipoPreguntaId=1, Pregunta="¿Cuáles son los 5 ejes de la Carta de Identidad donde se encuentran los 22 compromisos solemnes que las personas que colaboran con Movimiento Ciudadano se comprometen a cumplir?",Activo=true,FechaAlta=DateTime.UtcNow},

        };
    }
}
