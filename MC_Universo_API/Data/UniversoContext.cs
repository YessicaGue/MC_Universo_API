using MC_Universo_API.Controllers.Candidatos;
using MC_Universo_API.Data.Seed;
using MC_Universo_API.Data.Seed.AccionesAfirmativas;
using MC_Universo_API.Data.Seed.CaminoHeroeCiudadano;
using MC_Universo_API.Data.Seed.FormularioParticipacionEventos;
using MC_Universo_API.Data.Seed.Precandidaturas;
using MC_Universo_API.Data.Seed.CirculosCiudadanos;
using MC_Universo_API.Models;
using MC_Universo_API.Models.AccionesAfirmativas;
using MC_Universo_API.Models.CaminoHeroeCiudadano;
using MC_Universo_API.Models.Candidatos;
using MC_Universo_API.Models.FormularioParticipacionEventos;
using MC_Universo_API.Models.Precandidaturas;
using MC_Universo_API.Models.SecretariaOrganizacionAccionPolitica;
using MC_Universo_API.Models.CirculosCiudadanos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MC_Universo_API.Data;

public class UniversoContext(DbContextOptions<UniversoContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed Data
        Usuario_Seed usuarioSeed = new();
        modelBuilder.Entity<Usuario>().HasData(usuarioSeed.Usuarios);
        Escolaridad_Seed escolaridadesSeed = new();
        modelBuilder.Entity<Escolaridad>().HasData(escolaridadesSeed.Escolaridades);
        Generos_Seed generosSeed = new();
        modelBuilder.Entity<Genero>().HasData(generosSeed.Generos);
        Intereses_Seed interesesSeed = new();
        modelBuilder.Entity<GrupoIntereses>().HasData(interesesSeed.GruposIntereses);
        modelBuilder.Entity<Interes>().HasData(interesesSeed.Intereses);
        modelBuilder.Entity<InteresGrupoIntereses>().HasData(interesesSeed.InteresesUnion);
        Habilidades_Seed habilidadesSeed = new();
        modelBuilder.Entity<Habilidad>().HasData(habilidadesSeed.Habilidades);
        Motivos_Seed motivosSeed = new();
        modelBuilder.Entity<Motivo>().HasData(motivosSeed.Motivos);
        EventoTipos_Seed eventoTiposSeed = new();
        modelBuilder.Entity<EventoTipo>().HasData(eventoTiposSeed.EventoTipos);
        EntidadFederativa_Seed entidadFederativaSeed = new();
        modelBuilder.Entity<EntidadFederativa>().HasData(entidadFederativaSeed.EntidadesFederativas);
        Persona_Seed personaSeed = new();
        modelBuilder.Entity<Persona>().HasData(personaSeed.Personas);
        TipoContacto_Seed tipoContactoSeed = new();
        modelBuilder.Entity<TipoContacto>().HasData(tipoContactoSeed.TipoContactos);
        DatoContacto_Seed datoContactoSeed = new();
        modelBuilder.Entity<DatoContacto>().HasData(datoContactoSeed.DatoContactos);
        CatalogoCategoriasPreguntasEncuestas_Seed catalogoCategoriasPreguntasEncuestasSeed = new();
        modelBuilder.Entity<CatalogoCategoriasPreguntasEncuestas>()
            .HasData(catalogoCategoriasPreguntasEncuestasSeed.CatalogosCategoriasPreguntasEncuestas);
        CatalogoPreguntasEncuestas_Seed catalogoPreguntasEncuestasSeed = new();
        modelBuilder.Entity<CatalogoPreguntasEncuestas>()
            .HasData(catalogoPreguntasEncuestasSeed.CatalogosPreguntasEncuestas);
        CatalogoEstatusVoluntario_Seed catalogoEstatusVoluntarioSeed = new();
        modelBuilder.Entity<CatalogoEstatusVoluntario>()
            .HasData(catalogoEstatusVoluntarioSeed.CatalogosEstatusVoluntario);
        Area_Seed area = new();
        modelBuilder.Entity<Area>().HasData(area.Areas);
        Causa_Seed causa = new();
        modelBuilder.Entity<Causa>().HasData(causa.Causas);
        CatalogoOchoAcciones_Seed catalogoOchoAcciones = new();
        modelBuilder.Entity<CatalogoOchoAcciones>().HasData(catalogoOchoAcciones.CatalogosOchoAcciones);
        CatalogoPreguntasOchoAcciones_Seed catalogoPreguntasOchoAcciones = new();
        modelBuilder.Entity<CatalogoPreguntasOchoAcciones>()
            .HasData(catalogoPreguntasOchoAcciones.CatalogosPreguntasOchoAcciones);
        CatalogoPublicaciones_Seed catalogoPublicaciones = new();
        modelBuilder.Entity<CatalogoPublicaciones>().HasData(catalogoPublicaciones.CatalogosPublicaciones);
        CatalogoConfiguraciones_Seed catalogoConfiguraciones = new();
        modelBuilder.Entity<CatalogoConfiguraciones>().HasData(catalogoConfiguraciones.CatalogosConfiguraciones);
        CatalogoRedesSociales_Seed catalogoRedesSociales = new();
        modelBuilder.Entity<CatalogoRedesSociales>().HasData(catalogoRedesSociales.CatalogosRedesSociales);
        CatalogoCausasLanding_Seed catalogoCausasLanding = new();
        modelBuilder.Entity<CatalogoCausasLanding>().HasData(catalogoCausasLanding.CatalogosCausasLanding);
        CatalogoPublicacionesPerfilGrupal_Seed catalogoPublicacionesPerfilGrupal = new();
        modelBuilder.Entity<CatalogoPublicacionesPerfilGrupal>()
            .HasData(catalogoPublicacionesPerfilGrupal.CatalogosPublicacionesPerfilGrupal);
        CatalogoTokens_Seed catalogoTokens = new();
        modelBuilder.Entity<CatalogoTokens>().HasData(catalogoTokens.CatalogosTokens);
        PerfilesGrupales_Seed perfilesGrupales = new();
        modelBuilder.Entity<PerfilGrupal>().HasData(perfilesGrupales.PerfilGrupal);

        /*CHC*/
        CatalogoCaminosCHC_Seed catalogoCaminosCHC = new();
        modelBuilder.Entity<CatalogoCaminosCHC>().HasData(catalogoCaminosCHC.CatalogosCaminosCHC);
        CatalogoEstatusDocumentosEligibilidadCHC_Seed catalogoEstatusDocumentosEligibilidadCHC = new();
        modelBuilder.Entity<CatalogoEstatusDocumentosEligibilidadCHC>()
            .HasData(catalogoEstatusDocumentosEligibilidadCHC.CatalogosEstatusDocumentosEligibilidadCHC);
        CatalogoEtapasCHC_Seed catalogoEtapasCHC = new();
        modelBuilder.Entity<CatalogoEtapasCHC>().HasData(catalogoEtapasCHC.CatalogosEtapasCHC);
        CatalogoTiposEtapasCHC_Seed catalogoTiposEtapasCHC = new();
        modelBuilder.Entity<CatalogoTiposEtapasCHC>().HasData(catalogoTiposEtapasCHC.CatalogosTiposEtapasCHC);
        CatalogoTiposPreguntas_Seed catalogoTiposPreguntas = new();
        modelBuilder.Entity<CatalogoTiposPreguntas>().HasData(catalogoTiposPreguntas.CatalogosTiposPreguntas);
        ExamenesCHC_Seed examenesCHC = new();
        modelBuilder.Entity<ExamenesCHC>().HasData(examenesCHC.ExamenesCHC);
        PreguntasExamenCHC_Seed preguntasExamenCHC = new();
        modelBuilder.Entity<PreguntasExamenCHC>().HasData(preguntasExamenCHC.PreguntasExamenCHC);
        RespuestasExamenCHC_Seed respuestasExamenCHC = new();
        modelBuilder.Entity<RespuestaExamenCHC>().HasData(respuestasExamenCHC.RespuestaExamenCHC);
        CatalogoEtapaRegistroCHC_Seed catalogoEtapaRegistroCHC = new();
        modelBuilder.Entity<CatalogoEtapaRegistroCHC>().HasData(catalogoEtapaRegistroCHC.CatalogoEtapaRegistroCHC);
        CatalogoDocumentosEligibilidadCHC_Seed catalogoDocumentosEligibilidad = new();
        modelBuilder.Entity<CatalogoDocumentosEligibilidadCHC>()
            .HasData(catalogoDocumentosEligibilidad.CatalogoDocumentosEligibilidadCHC);

        /*Acciones afirmativas*/
        CatalogoCircunscripcion_Seed catalogoCircunscripcionSeed = new();
        modelBuilder.Entity<CatalogoCircunscripcion>().HasData(catalogoCircunscripcionSeed.CatalogoCircunscripcion);

        CatalogoRepresentante_Seed catalogoRepresentanteSeed = new();
        modelBuilder.Entity<CatalogoRepresentante>().HasData(catalogoRepresentanteSeed.CatalogoRepresentante);

        DatoEsperadoPorTipoCandidatura_Seed datosEsperadosPorTipoCandidaturaSeed = new();
        modelBuilder.Entity<DatosEsperadosPorTipoCandidatura>()
            .HasData(datosEsperadosPorTipoCandidaturaSeed.DatoEsperadoPorTipoCandidatura);

        DetalleRequisitoDiputaciones_Seed detalleRequisitoDiputacionesSeed = new();
        modelBuilder.Entity<DetalleRequisitoDiputaciones>()
            .HasData(detalleRequisitoDiputacionesSeed.DetalleRequisitoDiputaciones);

        DistritosFederales_Seed distritosFederalesSeed = new();
        modelBuilder.Entity<DistritosFederales>().HasData(distritosFederalesSeed.DistritosFederales);

        EstadoCircunscripcion_Seed estadoCircunscripcionSeed = new();
        modelBuilder.Entity<EstadoCircunscripcion>().HasData(estadoCircunscripcionSeed.EstadoCircunscripcion);

        CatalogoAccionesAfirmativas_Seed catalogoAccionesAfirmativasSeed = new();
        modelBuilder.Entity<CatalogoAccionesAfirmativas>()
            .HasData(catalogoAccionesAfirmativasSeed.CatalogoAccionesAfirmativas);

        ConteoAccionesAfirmativas_Seed conteoAccionesAfirmativasSeed = new();
        modelBuilder.Entity<ConteoAccionesAfirmativas>()
            .HasData(conteoAccionesAfirmativasSeed.ConteoAccionesAfirmativas);


        /* Secretaria de organizacion y accion publica */
        CatalogoEstadoValidacionArchivo_Seed catalogoEstadoValidacionArchivoSeed = new();
        modelBuilder.Entity<CatalogoEstadoValidacionArchivo>()
            .HasData(catalogoEstadoValidacionArchivoSeed.CatalogosEstadoValidacionArchivo);
        CatalogoRolComision_Seed catalogoRolComisionSeed = new();
        modelBuilder.Entity<CatalogoRolComision>().HasData(catalogoRolComisionSeed.CatalogosRolComision);
        CatalogoTipoArchivoSesion_Seed catalogoTipoArchivoSesionSeed = new();
        modelBuilder.Entity<CatalogoTipoArchivoSesion>()
            .HasData(catalogoTipoArchivoSesionSeed.CatalogosTipoArchivoSesion);
        CatalogoTipoComision_Seed catalogoTipoComisionSeed = new();
        modelBuilder.Entity<CatalogoTipoComision>().HasData(catalogoTipoComisionSeed.CatalogosTipoComision);
        CatalogoTipoSesion_Seed catalogoTipoSesionSeed = new();
        modelBuilder.Entity<CatalogoTipoSesion>().HasData(catalogoTipoSesionSeed.CatalogosTipoSesion);

        /* Precandidaturas */
        CatalogoTipoPrecandidatura_Seed catalogoTipoPrecandidaturaSeed = new();
        modelBuilder.Entity<CatalogoTipoPrecandidatura>()
            .HasData(catalogoTipoPrecandidaturaSeed.CatalogosTipoPrecandidatura);


        RequisitoPorCircunscripcion_Seed requisitoPorCircunscripcion_Seed = new();
        modelBuilder.Entity<RequisitoPorCircunscripcion>()
            .HasData(requisitoPorCircunscripcion_Seed.RequisitoPorCircunscripcion);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Usuario> Usuario { get; set; } = default!;

    public DbSet<BajasSistema> BajasSistema { get; set; } = default!;

    public DbSet<Causa> Causa { get; set; } = default!;

    public DbSet<CausaGrupoCausa> CausaGrupoCausa { get; set; } = default!;

    public DbSet<CodigoInvitacion> CodigoInvitacion { get; set; } = default!;

    public DbSet<DatoContacto> DatoContacto { get; set; } = default!;

    public DbSet<Direccion> Direccion { get; set; } = default!;

    public DbSet<Escolaridad> Escolaridad { get; set; } = default!;

    public DbSet<EntidadFederativa> EntidadFederativa { get; set; } = default!;

    public DbSet<EntidadFederativaGrupoEntidadFederativa> EntidadFederativaGrupoEntidadFederativa { get; set; } =
        default!;

    public DbSet<Evento> Evento { get; set; } = default!;

    public DbSet<EventoTipo> EventoTipo { get; set; } = default!;

    public DbSet<Genero> Genero { get; set; } = default!;

    public DbSet<GrupoCausa> GrupoCausa { get; set; } = default!;

    public DbSet<GrupoEntidadFederativa> GrupoEntidadFederativa { get; set; } = default!;

    public DbSet<GrupoIntereses> GrupoIntereses { get; set; } = default!;

    public DbSet<Habilidad> Habilidad { get; set; } = default!;

    public DbSet<HabilidadCustom> HabilidadCustom { get; set; } = default!;

    public DbSet<Interes> Interes { get; set; } = default!;

    public DbSet<InteresGrupoIntereses> InteresGrupoIntereses { get; set; } = default!;

    public DbSet<Invitado> Invitado { get; set; } = default!;

    public DbSet<Motivo> Motivo { get; set; } = default!;

    public DbSet<MotivoBaja> MotivoBaja { get; set; } = default!;
    public DbSet<Persona> Persona { get; set; } = default!;

    public DbSet<PersonaCausa> PersonaCausa { get; set; } = default!;

    public DbSet<PersonaCodigoInvitacion> PersonaCodigoInvitacion { get; set; } = default!;

    public DbSet<PersonaEscolaridad> PersonaEscolaridad { get; set; } = default!;

    public DbSet<PersonaGenero> PersonaGenero { get; set; } = default!;

    public DbSet<PersonaHabilidad> PersonaHabilidad { get; set; } = default!;

    public DbSet<PersonaInteres> PersonaInteres { get; set; } = default!;

    public DbSet<PersonaMotivo> PersonaMotivo { get; set; } = default!;

    public DbSet<TipoContacto> TipoContacto { get; set; } = default!;

    public DbSet<CatalogoCategoriasPreguntasEncuestas> CatalogoCategoriasPreguntasEncuestas { get; set; } = default!;

    public DbSet<CatalogoPreguntasEncuestas> CatalogoPreguntasEncuestas { get; set; } = default!;

    public DbSet<CatalogoEstatusVoluntario> CatalogoEstatusVoluntario { get; set; } = default!;

    public DbSet<RespuestasEncuesta> RespuestasEncuesta { get; set; } = default!;


    public DbSet<Encuesta> Encuesta { get; set; } = default!;

    public DbSet<Programa> Programa { get; set; } = default!;

    public DbSet<Voluntario> Voluntario { get; set; } = default!;

    public DbSet<VoluntarioComentario> VoluntarioComentario { get; set; } = default!;

    public DbSet<VoluntarioPrograma> VoluntarioPrograma { get; set; } = default!;

    public DbSet<VoluntarioHabilidad> VoluntarioHabilidad { get; set; } = default!;

    public DbSet<VoluntarioInteres> VoluntarioInteres { get; set; } = default!;

    public DbSet<Area> Area { get; set; } = default!;

    public DbSet<ProgramaArea> ProgramaArea { get; set; } = default!;

    public DbSet<ProgramaResponsable> ProgramaResponsable { get; set; } = default!;

    public DbSet<Escucha> Escucha { get; set; } = default!;

    public DbSet<RegistroCausa> RegistroCausa { get; set; } = default!;

    public DbSet<RegistroCausaCausa> RegistroCausaCausa { get; set; } = default!;

    public DbSet<CatalogoOchoAcciones> CatalogoOchoAcciones { get; set; } = default!;

    public DbSet<CatalogoPreguntasOchoAcciones> CatalogoPreguntasOchoAcciones { get; set; } = default!;

    public DbSet<RegistroOchoAcciones> RegistroOchoAcciones { get; set; } = default!;

    public DbSet<RegistroOchoAccionesCatalogoOchoAcciones> RegistroOchoAccionesCatalogoOchoAcciones { get; set; } =
        default!;

    public DbSet<RespuestasOchoAcciones> RespuestasOchoAcciones { get; set; } = default!;

    public DbSet<RegistroOchoAccionesHabilidad> RegistroOchoAccionesHabilidad { get; set; } = default!;

    public DbSet<RegistroOchoAccionesInteres> RegistroOchoAccionesInteres { get; set; } = default!;

    public DbSet<RegistroOchoAccionesUsuario> RegistroOchoAccionesUsuario { get; set; } = default!;

    public DbSet<RegistroOchoAccionesUsuarioCatalogoOchoAcciones> RegistroOchoAccionesUsuarioCatalogoOchoAcciones
    {
        get;
        set;
    } = default!;

    public DbSet<RespuestasOchoAccionesRegistroOchoAccionesUsuario> RespuestasOchoAccionesRegistroOchoAccionesUsuario
    {
        get;
        set;
    } = default!;

    public DbSet<CatalogoPublicaciones> CatalogoPublicaciones { get; set; } = default!;

    public DbSet<Archivo> Archivo { get; set; } = default!;

    public DbSet<Publicacion> Publicacion { get; set; } = default!;


    public DbSet<PublicacionArchivo> PublicacionArchivo { get; set; } = default!;

    public DbSet<Perfil> Perfil { get; set; } = default!;

    public DbSet<UsuarioPerfil> UsuarioPerfil { get; set; } = default!;

    public DbSet<PerfilSiguePerfil> PerfilSiguePerfil { get; set; } = default!;

    public DbSet<CatalogoConfiguraciones> CatalogoConfiguraciones { get; set; } = default!;

    public DbSet<CatalogoRedesSociales> CatalogoRedesSociales { get; set; } = default!;

    public DbSet<PerfilCatalogoRedesSociales> PerfilCatalogoRedesSociales { get; set; } = default!;

    public DbSet<CatalogoCausasLanding> CatalogoCausasLanding { get; set; } = default!;

    public DbSet<FormularioTemasInteres> FormularioTemasInteres { get; set; } = default!;

    public DbSet<FormularioTemasInteresCatalogoCausasLanding>
        FormularioTemasInteresCatalogoCausasLanding { get; set; } = default!;

    public DbSet<EscuchaFormularioTemasInteres> EscuchaFormularioTemasInteres { get; set; } = default!;

    public DbSet<PerfilGrupal> PerfilGrupal { get; set; } = default!;

    public DbSet<UsuarioPerfilGrupal> UsuarioPerfilGrupal { get; set; } = default!;

    public DbSet<PerfilSiguePerfilGrupal> PerfilSiguePerfilGrupal { get; set; } = default!;

    public DbSet<CatalogoPublicacionesPerfilGrupal> CatalogoPublicacionesPerfilGrupal { get; set; } = default!;

    public DbSet<PublicacionPerfilGrupal> PublicacionPerfilGrupal { get; set; } = default!;

    public DbSet<Token> Token { get; set; } = default!;

    public DbSet<PerfilToken> PerfilToken { get; set; } = default!;

    public DbSet<CatalogoTokens> CatalogoTokens { get; set; } = default!;

    public DbSet<PerfilGrupalToken> PerfilGrupalToken { get; set; } = default!;

    public DbSet<PerfilGrupalCatalogoRedesSociales> PerfilGrupalCatalogoRedesSociales { get; set; } = default!;

    public DbSet<PerfilUsuario> PerfilUsuario { get; set; } = default!;

    public DbSet<CatalogoCaminosCHC> CatalogoCaminosCHC { get; set; } = default!;

    public DbSet<CatalogoCargosPostulacion> CatalogoCargosPostulacion { get; set; } = default!;

    public DbSet<CatalogoDocumentosEligibilidadCHC> CatalogoDocumentosEligibilidadCHC { get; set; } = default!;

    public DbSet<CatalogoEstatusDocumentosEligibilidadCHC> CatalogoEstatusDocumentosEligibilidadCHC { get; set; } =
        default!;

    public DbSet<CatalogoEtapasCHC> CatalogoEtapasCHC { get; set; } = default!;

    public DbSet<CatalogoNivelesCargos> CatalogoNivelesCargos { get; set; } = default!;

    public DbSet<CatalogoTiposEtapasCHC> CatalogoTiposEtapasCHC { get; set; } = default!;

    public DbSet<CatalogoTiposPreguntas> CatalogoTiposPreguntas { get; set; } = default!;

    public DbSet<PerfilUsuarioPerfilGrupal> PerfilUsuarioPerfilGrupal { get; set; } = default!;

    public DbSet<AvanceEtapasCandidato> AvanceEtapasCandidato { get; set; } = default!;

    public DbSet<CandidatosCHC> CandidatosCHC { get; set; } = default!;

    public DbSet<ConfiguracionCHC> ConfiguracionCHC { get; set; } = default!;

    public DbSet<ContenidoPantallasEtapasCHC> ContenidoPantallasEtapasCHC { get; set; } = default!;

    public DbSet<DetalleCandidatosExamenes> DetalleCandidatosExamenes { get; set; } = default!;

    public DbSet<DocumentoCandidatosCHC> DocumentoCandidatosCHC { get; set; } = default!;

    public DbSet<CandidatosExamenes> CandidatosExamenes { get; set; } = default!;

    public DbSet<ExamenesCHC> ExamenesCHC { get; set; } = default!;

    public DbSet<PreguntasExamenCHC> PreguntasExamenCHC { get; set; } = default!;

    public DbSet<RespuestaExamenCHC> RespuestaExamenCHC { get; set; } = default!;

    public DbSet<PerfilPersonaCHC> PerfilPersonaCHC { get; set; } = default!;

    public DbSet<ContenidoPantallasEtapasCHCCatalogoEtapasCHC> ContenidoPantallasEtapasCHCCatalogoEtapasCHC
    {
        get;
        set;
    } = default!;

    public DbSet<CandidatoEtapaRegistroCHC> CandidatoEtapaRegistroCHC { get; set; } = default!;

    public DbSet<CatalogoEtapaRegistroCHC> CatalogoEtapaRegistroCHC { get; set; } = default!;

    public DbSet<PerfilUsuarioCodigoInvitacion> PerfilUsuarioCodigoInvitacion { get; set; } = default!;

    public DbSet<DomicilioOirRecibirNotificacionesCHC> DomicilioOirRecibirNotificacionesCHC { get; set; } = default!;

    /*Acciones Afirmativas*/

    public DbSet<CandidatoPersona> CandidatoPersona { get; set; } = default!;


    public DbSet<CatalogoCircunscripcion> CatalogoCircunscripcion { get; set; } = default!;

    public DbSet<CatalogoNivelCargo> CatalogoNivelCargo { get; set; } = default!;


    public DbSet<CatalogoRepresentante> CatalogoRepresentante { get; set; } = default!;

    public DbSet<CircunscripcionEstado> CircunscripcionEstado { get; set; } = default!;

    public DbSet<DatosEsperadosPorTipoCandidatura> DatosEsperadosPorTipoCandidatura { get; set; } = default!;

    public DbSet<DetalleRequisitoDiputaciones> DetalleRequisitoDiputaciones { get; set; } = default!;


    public DbSet<DistritosFederales> DistritosFederales { get; set; } = default!;


    public DbSet<EstadoCircunscripcion> EstadoCircunscripcion { get; set; } = default!;

    public DbSet<RequisitoPorCircunscripcion> RequisitoPorCircunscripcion { get; set; } = default!;

    public DbSet<CatalogoAccionesAfirmativas> CatalogoAccionesAfirmativas { get; set; } = default!;

    public DbSet<ConteoAccionesAfirmativas> ConteoAccionesAfirmativas { get; set; } = default!;

    /**/

    public DbSet<PerfilGrupalSiguePerfil> PerfilGrupalSiguePerfil { get; set; } = default!;

    public DbSet<PerfilGrupalSiguePerfilGrupal> PerfilGrupalSiguePerfilGrupal { get; set; } = default!;


    /* Secretaria de organizacion y accion politica */
    public DbSet<CatalogoEstadoValidacionArchivo> CatalogoEstadoValidacionArchivo { get; set; } = default!;
    public DbSet<CatalogoRolComision> CatalogoRolComision { get; set; } = default!;
    public DbSet<CatalogoTipoArchivoSesion> CatalogoTipoArchivoSesion { get; set; } = default!;
    public DbSet<CatalogoTipoComision> CatalogoTipoComision { get; set; } = default!;
    public DbSet<CatalogoTipoSesion> CatalogoTipoSesion { get; set; } = default!;
    public DbSet<Comision> Comision { get; set; } = default!;
    public DbSet<ComisionUsuario> ComisionUsuario { get; set; } = default!;
    public DbSet<Sesion> Sesion { get; set; } = default!;
    public DbSet<SesionArchivo> SesionArchivo { get; set; } = default!;
    
    /* Precandidaturas */
    public DbSet<CatalogoTipoPrecandidatura> CatalogoTipoPrecandidatura { get; set; } = default!;
    public DbSet<ApoyoPrecandidatura> ApoyoPrecandidatura { get; set; } = default!;
    public DbSet<PerfilPrecandidatura> PerfilPrecandidatura { get; set; } = default!;
    public DbSet<CatalogoPuestoPrecandidatura> CatalogoPuestoPrecandidatura { get; set; } = default!;
    public DbSet<PrecandidaturaCoadministrador> PrecandidaturaCoadministrador { get; set; } = default!;

    //RegistroParticipantesEventos
    public DbSet<RegistroParticipantesEventos> RegistroParticipantesEventos { get; set; } = default!;
    public DbSet<DomicilioGeneral> DomicilioGeneral { get; set; } = default!;
    public DbSet<EntidadFederativaCodigoEvento> EntidadFederativaCodigoEventos { get; set; } = default!;
    public DbSet<CuestionarioCandidato> CuestionarioCandidato { get; set; } = default!;
    public DbSet<PerfilPersona> PerfilPersona { get; set; } = default!;

    // CírculosCiudadanos
    public DbSet<CatalogoEstatusCirculo> CatalogoEstatusCirculo { get; set; } = default!;
    public DbSet<Circulo> Circulo { get; set; } = default!;
    public DbSet<HistoricoEstatusCirculo> HistoricoEstatusCirculo { get; set; } = default!;
    public DbSet<PerfilCirculo> PerfilCirculo { get; set; } = default!;
    public DbSet<PerfilInvitacionCirculo> PerfilInvitacionCirculo { get; set; } = default!;
    public DbSet<TareaCirculo> TareaCirculo { get; set; } = default!;
    public DbSet<CatalogoCheckInsCedulaCirculo> CatalogoCheckInsCedulaCirculo { get; set; } = default!;
    public DbSet<CedulaRegistroCheckIns> CedulaRegistroCheckIns { get; set; } = default!;
    public DbSet<CirculoCausa> CirculoCausa { get; set; } = default!;
    
    // EncuestaCausasCandidato
    public DbSet<EncuestaCausasCandidato> EncuestaCausasCandidato { get; set; } = default!;
    public DbSet<EncuestaCausasCandidatoPregunta> EncuestaCausasCandidatoPregunta { get; set; } = default!;
    public DbSet<EncuestaCausasCandidatoOpcion> EncuestaCausasCandidatoOpcion { get; set; } = default!;
    
    public DbSet<AvatarCandidato> Avatares { get; set; } = default!;
}