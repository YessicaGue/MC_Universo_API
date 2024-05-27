using MC_Universo_API.Models.CaminoHeroeCiudadano;

namespace MC_Universo_API.Data.Seed.CaminoHeroeCiudadano
{
    public class RespuestasExamenCHC_Seed
    {
        public readonly List<RespuestaExamenCHC> RespuestaExamenCHC = new()
        {
            new RespuestaExamenCHC{Id=1,PreguntaExamenCHCId=1,Respuesta="Encontrar a los mejores perfiles para defender las causas de la ciudadanía y convertirlos en héroes ciudadan@s.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=2,PreguntaExamenCHCId=1,Respuesta="Dar un lugar a las personas para que se conozcan y compitan para divertirse.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=3,PreguntaExamenCHCId=1,Respuesta="No lo sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=4,PreguntaExamenCHCId=2,Respuesta="Para permitir que las personas que se registren en un camino avancen más rápido que los que participan en otro.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=5,PreguntaExamenCHCId=2,Respuesta="Para revertir la desigualdad que enfrentan en el ejercicio de sus derechos político-electorales algunos grupos en situación de discriminación o vulnerabilidad.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=6,PreguntaExamenCHCId=2,Respuesta="No lo sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=7,PreguntaExamenCHCId=3,Respuesta="Sí, tendré una candidatura asegurada cuando comience el proceso de selección de precandidaturas.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=8,PreguntaExamenCHCId=3,Respuesta="No, pero tendré elementos que me permitan ser considerado en el proceso de selección de precandidaturas.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=9,PreguntaExamenCHCId=3,Respuesta="No sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=10,PreguntaExamenCHCId=4,Respuesta="Sí, tengo que cumplir con la entrega de documentos ante el INE como lo estipula la ley.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=11,PreguntaExamenCHCId=4,Respuesta="No, con la información que cargue en la plataforma del Camino del Héroe Ciudadano será suficiente.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=12,PreguntaExamenCHCId=4,Respuesta="No sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=13,PreguntaExamenCHCId=5,Respuesta="Sí, puedo participar en diferentes caminos siempre y cuando cumpla con los requisitos de acceso del camino",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=14,PreguntaExamenCHCId=5,Respuesta="No, solamente puedo participar en un camino ya que existe un camino que contempla a las personas que cumplen varios requisitos de acceso.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=15,PreguntaExamenCHCId=5,Respuesta="No sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            //Respuestas Examenes Valores/Principios
            new RespuestaExamenCHC{Id=16,PreguntaExamenCHCId=6,Respuesta="Haber sido condenado o sentenciado por una agresión de género, delitos sexuales, o por ser deudor alimentario.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=17,PreguntaExamenCHCId=6,Respuesta="No presentar tu declaración patrimonial en tiempo y forma.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=18,PreguntaExamenCHCId=6,Respuesta="No lo sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=19,PreguntaExamenCHCId=7,Respuesta="Carta Progresista, Carta Compromiso,Carta de Identidad, Declaración de Principios y Programa de Acción de Movimiento Ciudadano.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=20,PreguntaExamenCHCId=7,Respuesta="Plan de Acción, Carta Compromiso, Estatutos, Carta Progresista y Libro de Valores de Movimiento Ciudadano.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=21,PreguntaExamenCHCId=7,Respuesta="No lo sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=22,PreguntaExamenCHCId=8,Respuesta="Si.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=23,PreguntaExamenCHCId=8,Respuesta="No.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=24,PreguntaExamenCHCId=8,Respuesta="No lo sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=25,PreguntaExamenCHCId=9,Respuesta="Democracia social, igualdad sustantiva entre hombres y mujeres, economía social de mercado, inclusión social y fortalecimiento del poder ciudadano.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=26,PreguntaExamenCHCId=9,Respuesta="Desarrollo económico basado en el uso de combustibles fósiles, asistencialismo social, centralismo político.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=27,PreguntaExamenCHCId=9,Respuesta="No lo sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=28,PreguntaExamenCHCId=10,Respuesta="Desarrollo económico, Pluralismo, Salud y bienestar, Educación y Seguridad.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=29,PreguntaExamenCHCId=10,Respuesta="Estado, soberanía popular y democracia; Derechos humanos; Equidad y desarrollo económico; Rendición de cuentas, transparencia y combate a la corrupción; Federalismo y Municipalismo.",EsCorrecta=true,Activo=true,FechaAlta=DateTime.UtcNow},
            new RespuestaExamenCHC{Id=30,PreguntaExamenCHCId=10,Respuesta="No lo sé.",EsCorrecta=false,Activo=true,FechaAlta=DateTime.UtcNow},
        };
    }
}
