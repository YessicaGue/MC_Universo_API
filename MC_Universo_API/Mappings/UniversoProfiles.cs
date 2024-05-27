using AutoMapper;
using MC_Universo_API.Data.Seed.FormularioParticipacionEventos;
using MC_Universo_API.Models;
using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Models.CirculosCiudadanos;
using MC_Universo_API.Models.FormularioParticipacionEventos;
using MC_Universo_API.Models.Precandidaturas;
using MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica;
using MC_Universo_API.ViewModels;
using MC_Universo_API.ViewModels.AccionesAfirmativas;
using MC_Universo_API.ViewModels.CaminoHeroeCiudadanoViewModels;
using MC_Universo_API.ViewModels.FormularioParticipacionEventos;
using MC_Universo_API.ViewModels.CirculosCiudadanos;
using Newtonsoft.Json;
using MC_Universo_API.ViewModels.Precandidaturas;

namespace MC_Universo_API.Mappings
{
    public class UniversoProfiles : Profile
    {
        public UniversoProfiles()
        {

            CreateMap<CatalogoPreguntasEncuestasViewModel, CatalogoPreguntasEncuestas>();
            CreateMap<RespuestasEncuestaViewModel, RespuestasEncuesta>();
            CreateMap<EncuestaViewModel, Encuesta>();
            CreateMap<ProgramaViewModel, Programa>();
            CreateMap<VoluntarioViewModel, Voluntario>();
            CreateMap<VoluntarioComentarioViewModel, VoluntarioComentario>();
            CreateMap<VoluntarioProgramaViewModel, VoluntarioPrograma>();
            CreateMap<VoluntarioHabilidadViewModel, VoluntarioHabilidad>();
            CreateMap<VoluntarioInteresViewModel, VoluntarioInteres>();
            CreateMap<ProgramaAreaViewModel, ProgramaArea>();
            CreateMap<ProgramaResponsableViewModel, ProgramaResponsable>();
            CreateMap<InteresGrupoInteresesViewModel,  InteresGrupoIntereses>();
            CreateMap<RegistroCausaViewModel, RegistroCausa>();
            CreateMap<RegistroCausaCausaViewModel, RegistroCausaCausa>();
            CreateMap<RespuestasOchoAccionesViewModel, RespuestasOchoAcciones>();
            CreateMap<RegistroOchoAccionesCatalogoOchoAccionesViewModel, RegistroOchoAccionesCatalogoOchoAcciones>();
            CreateMap<RegistroOchoAccionesHabilidadViewModel, RegistroOchoAccionesHabilidad>();
            CreateMap<RegistroOchoAccionesInteresViewModel, RegistroOchoAccionesInteres>();
            CreateMap<RegistroOchoAccionesViewModel, RegistroOchoAcciones>();
            CreateMap<RegistroOchoAccionesUsuarioCatalogoOchoAccionesViewModel, RegistroOchoAccionesUsuarioCatalogoOchoAcciones>();
            CreateMap<RespuestasOchoAccionesRegistroOchoAccionesUsuarioViewModel, RespuestasOchoAccionesRegistroOchoAccionesUsuario>();
            CreateMap<EscuchaViewModel, Escucha>();
            CreateMap<ArchivoViewModel, Archivo>();
            CreateMap<PublicacionViewModel, Publicacion>();
            CreateMap<PublicacionArchivoViewModel, PublicacionArchivo>();
            CreateMap<PerfilViewModel, Perfil>();
            CreateMap<UsuarioPerfilViewModel,  UsuarioPerfil>();
            CreateMap<PerfilSiguePerfilViewModel, PerfilSiguePerfil>();
            CreateMap<PerfilCatalogoRedesSocialesViewModel, PerfilCatalogoRedesSociales>();
            CreateMap<FormularioTemasInteresViewModel, FormularioTemasInteres>();
            CreateMap<FormularioTemasInteresCatalogoCausasLandingViewModel, FormularioTemasInteresCatalogoCausasLanding>();
            CreateMap<EscuchaFormularioTemasInteresViewModel, EscuchaFormularioTemasInteres>();
            CreateMap<PerfilGrupalViewModel, PerfilGrupal>();
            CreateMap<PerfilSiguePerfilGrupalViewModel, PerfilSiguePerfilGrupal>();
            CreateMap<PublicacionPerfilGrupalViewModel, PublicacionPerfilGrupal>();
            CreateMap<TokenViewModel,  Token>();
            CreateMap<PerfilTokenViewModel, PerfilToken>();
            CreateMap<PerfilGrupalTokenViewModel, PerfilGrupalToken>();
            CreateMap<PerfilGrupalCatalogoRedesSocialesViewModel, PerfilGrupalCatalogoRedesSociales>();
            CreateMap<PerfilUsuarioViewModel, PerfilUsuario>();
            CreateMap<PerfilUsuarioPerfilGrupalViewModel, PerfilUsuarioPerfilGrupal>();
            CreateMap<PersonaPerfilCHCViewModel, PerfilPersonaCHC>();
            CreateMap<PersonaViewModel, Persona>();
            CreateMap<CandidatosCHCViewModel, CandidatosCHC>();
            CreateMap<DireccionViewModel, Direccion>();
            CreateMap<ContenidoPantallasEtapasCHCCatalogoEtapasCHCViewModel, ContenidoPantallasEtapasCHCCatalogoEtapasCHC>();
            CreateMap<ContenidoPantallasEtapasCHCViewModel, ContenidoPantallasEtapasCHC>();
            CreateMap<PerfilUsuarioCodigoInvitacionViewModel, PerfilUsuarioCodigoInvitacion>();
            CreateMap<CandidatoEtapaRegistroCHCViewModel, CandidatoEtapaRegistroCHC>();
            CreateMap<DocumentoCandidatosCHCViewModel, DocumentoCandidatosCHC>();
            CreateMap<ExamenesCandidatosViewModel, CandidatosExamenes>();
            CreateMap<DetalleExamenesCandidatosViewModel, DetalleCandidatosExamenes>();
            CreateMap<DomicilioOirRecibirNotificacionesCHC,DomicilioOirRecibirNotificacionesCHCViewModel>();
            CreateMap<PerfilGrupalSiguePerfilViewModel, PerfilGrupalSiguePerfil>();
            CreateMap<PerfilGrupalSiguePerfilGrupalViewModel, PerfilGrupalSiguePerfilGrupal>();
            CreateMap<CatalogoCircunscripcion, CatalogoCircuinscripcionViewModel>();

            /* Secretaria de organizacion y accion publica */
            CreateMap<CatalogoEstadoValidacionArchivoViewModel, CatalogoEstadoValidacionArchivo>();
            CreateMap<CatalogoRolComisionViewModel, CatalogoRolComision>();
            CreateMap<CatalogoTipoArchivoSesionViewModel, CatalogoTipoArchivoSesion>();
            CreateMap<CatalogoTipoComisionViewModel, CatalogoTipoComision>();
            CreateMap<CatalogoTipoSesionViewModel, CatalogoTipoSesion>();
            CreateMap<ComisionUsuarioViewModel, ComisionUsuario>();
            CreateMap<ComisionViewModel, Comision>();
            CreateMap<SesionArchivoViewModel, SesionArchivo>();
            CreateMap<SesionViewModel, Sesion>();

            /* Precandidaturas */
            CreateMap<CatalogoTipoPrecandidaturaViewModel, CatalogoTipoPrecandidatura>();
            CreateMap<PerfilPrecandidaturaViewModel, PerfilPrecandidatura>();
            CreateMap<ApoyoPrecandidaturaViewModel, ApoyoPrecandidatura>();
            CreateMap<PrecandidaturaCoadministradorViewModel, PrecandidaturaCoadministrador>();

            /*RegistroCandidatosEventos*/
            CreateMap<RegistroParticipantesEventosViewModel, RegistroParticipantesEventos>();
            CreateMap<DomiclioGeneralViewModel, DomicilioGeneral>();
            CreateMap<EntidadFederativaCodigoEventosViewModels,EntidadFederativaCodigoEvento>();


            CreateMap<PerfilPersonaViewModel, PerfilPersona>();

            /* CirculosCiudadanos */
            CreateMap<CatalogoEstatusCirculoViewModel, CatalogoEstatusCirculo>();
            CreateMap<CirculoViewModel, Circulo>();
            CreateMap<HistoricoEstatusCirculoViewModel,  HistoricoEstatusCirculo>();
            CreateMap<PerfilCirculoViewModel, PerfilCirculo>();
            CreateMap<TareaCirculoViewModel, TareaCirculo>();
            CreateMap<PerfilInvitacionCirculoViewModel, PerfilInvitacionCirculo>();
            CreateMap<CirculoCausaViewModel, CirculoCausa>();
        }
    }
}
