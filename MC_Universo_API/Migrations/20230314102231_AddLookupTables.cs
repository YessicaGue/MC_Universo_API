using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AddLookupTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "causa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_causa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "causa_grupo_causa",
                columns: table => new
                {
                    causa_id = table.Column<int>(type: "integer", nullable: false),
                    grupo_causa_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_causa_grupo_causa", x => new { x.causa_id, x.grupo_causa_id });
                });

            migrationBuilder.CreateTable(
                name: "entidad_federativa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    iso_code = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_entidad_federativa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "escolaridad",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_escolaridad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "evento_tipo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    imagen = table.Column<string>(type: "text", nullable: true),
                    tipo_sesion = table.Column<bool>(type: "boolean", nullable: false, comment: "True = Sesion, False = Evento"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_evento_tipo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_genero", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grupo_causa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    url_imagen = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_grupo_causa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grupo_entidad_federativa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    manzana = table.Column<string>(type: "text", nullable: true),
                    seccion = table.Column<string>(type: "text", nullable: true),
                    distrito = table.Column<string>(type: "text", nullable: true),
                    zona = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_grupo_entidad_federativa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grupo_intereses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    url_imagen = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_grupo_intereses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "habilidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_habilidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "interes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_interes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "interes_grupo_intereses",
                columns: table => new
                {
                    interes_id = table.Column<int>(type: "integer", nullable: false),
                    grupo_intereses_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_interes_grupo_intereses", x => new { x.interes_id, x.grupo_intereses_id });
                });

            migrationBuilder.CreateTable(
                name: "invitado",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido_paterno = table.Column<string>(type: "text", nullable: true),
                    apellido_materno = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    sexo = table.Column<string>(type: "text", nullable: true),
                    entidad_federativa = table.Column<string>(type: "text", nullable: true),
                    cargo_organizacion = table.Column<string>(type: "text", nullable: true, comment: "El cargo u organización a la que pertenece el invitado"),
                    modo_participacion = table.Column<string>(type: "text", nullable: false, comment: "Puede ser: 'Presencial', 'Virtual' o 'Ambos'"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_invitado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motivo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_motivo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motivo_baja",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_motivo_baja", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido_paterno = table.Column<string>(type: "text", nullable: false),
                    apellido_materno = table.Column<string>(type: "text", nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    firma_electronica = table.Column<string>(type: "text", nullable: true),
                    curp = table.Column<string>(type: "text", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "persona_causa",
                columns: table => new
                {
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    causa_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_causa", x => new { x.persona_id, x.causa_id });
                });

            migrationBuilder.CreateTable(
                name: "persona_codigo_invitacion",
                columns: table => new
                {
                    codigo_invitacion_id = table.Column<int>(type: "integer", nullable: false),
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_aceptado = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_codigo_invitacion", x => new { x.codigo_invitacion_id, x.persona_id });
                });

            migrationBuilder.CreateTable(
                name: "persona_escolaridad",
                columns: table => new
                {
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    escolaridad_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_escolaridad", x => new { x.persona_id, x.escolaridad_id });
                });

            migrationBuilder.CreateTable(
                name: "persona_genero",
                columns: table => new
                {
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    genero_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_genero", x => new { x.persona_id, x.genero_id });
                });

            migrationBuilder.CreateTable(
                name: "persona_habilidad",
                columns: table => new
                {
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    habilidad_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_habilidad", x => new { x.persona_id, x.habilidad_id });
                });

            migrationBuilder.CreateTable(
                name: "persona_interes",
                columns: table => new
                {
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    interes_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_interes", x => new { x.persona_id, x.interes_id });
                });

            migrationBuilder.CreateTable(
                name: "persona_motivo",
                columns: table => new
                {
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    motivo_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persona_motivo", x => new { x.persona_id, x.motivo_id });
                });

            migrationBuilder.CreateTable(
                name: "tipo_contacto",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    es_email = table.Column<bool>(type: "boolean", nullable: false),
                    es_telefono = table.Column<bool>(type: "boolean", nullable: false),
                    es_whatsapp = table.Column<bool>(type: "boolean", nullable: false, comment: "Si es un telefono, se define si este tiene whatsapp o no"),
                    es_otro = table.Column<bool>(type: "boolean", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tipo_contacto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    rol = table.Column<string>(type: "text", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "entidad_federativa_grupo_entidad_federativa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    grupo_entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_entidad_federativa_grupo_entidad_federativa", x => x.id);
                    table.ForeignKey(
                        name: "fk_entidad_federativa_grupo_entidad_federativa_entidad_federat",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_entidad_federativa_grupo_entidad_federativa_grupo_entidad_f",
                        column: x => x.grupo_entidad_federativa_id,
                        principalTable: "grupo_entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bajas_sistema",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    persona_id = table.Column<int>(type: "integer", nullable: false, comment: "Id de la persona que se dio de baja"),
                    motivo_baja_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_baja = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bajas_sistema", x => x.id);
                    table.ForeignKey(
                        name: "fk_bajas_sistema_motivo_baja_motivo_baja_id",
                        column: x => x.motivo_baja_id,
                        principalTable: "motivo_baja",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_bajas_sistema_persona_persona_id",
                        column: x => x.persona_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "codigo_invitacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<Guid>(type: "uuid", nullable: false),
                    sponsor_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_codigo_invitacion", x => x.id);
                    table.ForeignKey(
                        name: "fk_codigo_invitacion_persona_sponsor_id",
                        column: x => x.sponsor_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "direccion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    direccion_completa = table.Column<string>(type: "text", nullable: false),
                    numero_calle = table.Column<string>(type: "text", nullable: true),
                    nombre_calle = table.Column<string>(type: "text", nullable: true),
                    colonia = table.Column<string>(type: "text", nullable: true),
                    ciudad = table.Column<string>(type: "text", nullable: false),
                    entidad_federativa_id = table.Column<int>(type: "integer", nullable: false),
                    codigo_postal = table.Column<string>(type: "text", nullable: true),
                    pais = table.Column<string>(type: "text", nullable: false),
                    latitud = table.Column<string>(type: "text", nullable: false),
                    longitud = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_direccion", x => x.id);
                    table.ForeignKey(
                        name: "fk_direccion_entidad_federativa_entidad_federativa_id",
                        column: x => x.entidad_federativa_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_direccion_persona_persona_id",
                        column: x => x.persona_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "evento",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    fecha_evento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    imagen = table.Column<string>(type: "text", nullable: false),
                    evento_tipo_id = table.Column<int>(type: "integer", nullable: false),
                    privacidad = table.Column<int>(type: "integer", nullable: false, comment: "1 = Publico, 2 = Lista de invitados, 3 = Privado"),
                    direccion = table.Column<string>(type: "text", nullable: false),
                    latitud = table.Column<string>(type: "text", nullable: false),
                    longitud = table.Column<string>(type: "text", nullable: false),
                    cupo_limitado = table.Column<bool>(type: "boolean", nullable: false),
                    numero_asistentes = table.Column<int>(type: "integer", nullable: false),
                    check_in_requerido = table.Column<bool>(type: "boolean", nullable: false),
                    responsable_id = table.Column<int>(type: "integer", nullable: false, comment: "Persona que creo el evento o es el responsable del mismo"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    fecha_eliminacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_evento", x => x.id);
                    table.ForeignKey(
                        name: "fk_evento_evento_tipo_evento_tipo_id",
                        column: x => x.evento_tipo_id,
                        principalTable: "evento_tipo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_evento_persona_responsable_id",
                        column: x => x.responsable_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "habilidad_custom",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_habilidad_custom", x => x.id);
                    table.ForeignKey(
                        name: "fk_habilidad_custom_persona_persona_id",
                        column: x => x.persona_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dato_contacto",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    valor = table.Column<string>(type: "text", nullable: false),
                    verificado = table.Column<bool>(type: "boolean", nullable: false),
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    tipo_contacto_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dato_contacto", x => x.id);
                    table.ForeignKey(
                        name: "fk_dato_contacto_persona_persona_id",
                        column: x => x.persona_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dato_contacto_tipo_contacto_tipo_contacto_id",
                        column: x => x.tipo_contacto_id,
                        principalTable: "tipo_contacto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "entidad_federativa",
                columns: new[] { "id", "fecha_creacion", "fecha_modificacion", "iso_code", "nombre" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2514), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2515), "AGS", "Aguascalientes" },
                    { 2, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2520), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2521), "BC", "Baja California" },
                    { 3, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2522), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2522), "BCS", "Baja California Sur" },
                    { 4, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2522), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2523), "CAM", "Campeche" },
                    { 5, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2523), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2523), "COA", "Coahuila" },
                    { 6, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2524), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2525), "COL", "Colima" },
                    { 7, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2525), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2526), "CHIS", "Chiapas" },
                    { 8, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2526), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2526), "CHIH", "Chihuahua" },
                    { 9, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2527), "CDMX", "Ciudad de México" },
                    { 10, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2529), "DGO", "Durango" },
                    { 11, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2529), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2530), "GTO", "Guanajuato" },
                    { 12, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2530), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2530), "GRO", "Guerrero" },
                    { 13, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2531), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2531), "HGO", "Hidalgo" },
                    { 14, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2532), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2532), "JAL", "Jalisco" },
                    { 15, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2533), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2533), "MEX", "Estado de México" },
                    { 16, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2534), "MICH", "Michoacán" },
                    { 17, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2534), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2535), "MOR", "Morelos" },
                    { 18, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2536), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2536), "NAY", "Nayarit" },
                    { 19, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2537), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2537), "NL", "Nuevo León" },
                    { 20, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2538), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2538), "OAX", "Oaxaca" },
                    { 21, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2538), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2539), "PUE", "Puebla" },
                    { 22, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2539), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2539), "QRO", "Querétaro" },
                    { 23, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2540), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2540), "QROO", "Quintana Roo" },
                    { 24, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2541), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2541), "SLP", "San Luis Potosí" },
                    { 25, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2542), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2542), "SIN", "Sinaloa" },
                    { 26, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2543), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2543), "SON", "Sonora" },
                    { 27, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2543), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2544), "TAB", "Tabasco" },
                    { 28, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2544), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2544), "TAMPS", "Tamaulipas" },
                    { 29, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2545), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2545), "TLAX", "Tlaxcala" },
                    { 30, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2546), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2546), "VER", "Veracruz" },
                    { 31, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2547), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2547), "YUC", "Yucatán" },
                    { 32, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2548), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2548), "ZAC", "Zacatecas" }
                });

            migrationBuilder.InsertData(
                table: "escolaridad",
                columns: new[] { "id", "activo", "nombre" },
                values: new object[,]
                {
                    { 1, true, "Primaria" },
                    { 2, true, "Secundaria" },
                    { 3, true, "Preparatoria o Bachiller" },
                    { 4, true, "Técnico superior" },
                    { 5, true, "Licenciatura" },
                    { 6, true, "Posgrado" },
                    { 7, true, "Otro" }
                });

            migrationBuilder.InsertData(
                table: "evento_tipo",
                columns: new[] { "id", "activo", "descripcion", "fecha_creacion", "imagen", "nombre", "tipo_sesion" },
                values: new object[,]
                {
                    { 1, true, "Este es un evento público.", new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2499), "https://i.imgur.com/4ZQZ5Zu.png", "Público General", false },
                    { 2, true, "Este es un evento para afiliados.", new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2502), "https://i.imgur.com/4ZQZ5Zu.png", "Afiliados", false },
                    { 3, true, "Este es un evento de tipo sesión.", new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2503), "https://i.imgur.com/4ZQZ5Zu.png", "Sesión", true }
                });

            migrationBuilder.InsertData(
                table: "genero",
                columns: new[] { "id", "activo", "nombre" },
                values: new object[,]
                {
                    { 1, true, "Masculino" },
                    { 2, true, "Femenino" },
                    { 3, true, "Chico" },
                    { 4, true, "Chica" },
                    { 5, true, "Bigénero" },
                    { 6, true, "Intersexual" },
                    { 7, true, "No binario" },
                    { 8, true, "Sin género" },
                    { 9, true, "No estoy seguro" },
                    { 10, true, "Prefiero no decir" },
                    { 11, true, "Otro" }
                });

            migrationBuilder.InsertData(
                table: "grupo_intereses",
                columns: new[] { "id", "activo", "nombre", "url_imagen" },
                values: new object[,]
                {
                    { 1, true, "Economía", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 2, true, "Fotografía", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 3, true, "Viajes", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 4, true, "Medio Ambiente", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 5, true, "Cocina", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 6, true, "Tecnología", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 7, true, "Moda", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 8, true, "Juegos", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" },
                    { 9, true, "Otros", "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80" }
                });

            migrationBuilder.InsertData(
                table: "habilidad",
                columns: new[] { "id", "activo", "nombre" },
                values: new object[,]
                {
                    { 1, true, "Comunicación efectiva" },
                    { 2, true, "Creatividad" },
                    { 3, true, "Inteligencia emocional" },
                    { 4, true, "Interpretación de datos" },
                    { 5, true, "Negociación" },
                    { 6, true, "Organización" },
                    { 7, true, "Resiliencia" },
                    { 8, true, "Resolución de problemas" },
                    { 9, true, "Toma de decisiones" },
                    { 10, true, "Trabajo en equipo" },
                    { 11, true, "Otro" }
                });

            migrationBuilder.InsertData(
                table: "interes",
                columns: new[] { "id", "activo", "nombre" },
                values: new object[,]
                {
                    { 1, true, "Inversiones" },
                    { 2, true, "Acciones" },
                    { 3, true, "Emancipación" },
                    { 4, true, "Criptomonedas" },
                    { 5, true, "Finanzas" },
                    { 6, true, "Trading" },
                    { 7, true, "Fotografía artística" },
                    { 8, true, "Fotografía conceptual" },
                    { 9, true, "Fotografía en blanco y negro" },
                    { 10, true, "Fotografía minimalista" },
                    { 11, true, "Fotografía abstracta" },
                    { 12, true, "Fotografía de retrato" },
                    { 13, true, "Turismo de aventura" },
                    { 14, true, "Turismo rural" },
                    { 15, true, "Turismo de naturaleza" },
                    { 16, true, "Turismo paranormal" },
                    { 17, true, "Movimientos para cuidado del agua" },
                    { 18, true, "Concientización de cambio climático" },
                    { 19, true, "Control de plagas" },
                    { 20, true, "Solidaridad en desastres naturales" },
                    { 21, true, "Protección de flora y fauna" },
                    { 22, true, "Cocina tradicional" },
                    { 23, true, "Cocina recreativa" },
                    { 24, true, "Alta cocina" },
                    { 25, true, "Comida italiana" },
                    { 26, true, "Comida libanesa" },
                    { 27, true, "Comida japonesa" },
                    { 28, true, "Comida peruana" },
                    { 29, true, "Comida mexicana" }
                });

            migrationBuilder.InsertData(
                table: "interes_grupo_intereses",
                columns: new[] { "grupo_intereses_id", "interes_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
                    { 4, 20 },
                    { 4, 21 },
                    { 5, 22 },
                    { 5, 23 },
                    { 5, 24 },
                    { 5, 25 },
                    { 5, 26 },
                    { 5, 27 },
                    { 5, 28 },
                    { 5, 29 }
                });

            migrationBuilder.InsertData(
                table: "motivo",
                columns: new[] { "id", "activo", "descripcion", "nombre" },
                values: new object[,]
                {
                    { 1, true, null, "Voluntario" },
                    { 2, true, null, "Servicio Social" },
                    { 3, true, null, "Prácticas Profesionales" }
                });

            migrationBuilder.InsertData(
                table: "persona",
                columns: new[] { "id", "apellido_materno", "apellido_paterno", "curp", "fecha_creacion", "fecha_modificacion", "fecha_nacimiento", "firma_electronica", "nombre" },
                values: new object[,]
                {
                    { 1, "Coeto", "Gomez", null, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2564), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2565), new DateTime(1994, 7, 24, 22, 0, 0, 0, DateTimeKind.Utc), null, "Jose Alfonso" },
                    { 2, null, "Naranja", null, new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2717), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(2718), new DateTime(2000, 1, 1, 22, 0, 0, 0, DateTimeKind.Utc), null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "tipo_contacto",
                columns: new[] { "id", "activo", "es_email", "es_otro", "es_telefono", "es_whatsapp", "nombre" },
                values: new object[,]
                {
                    { 1, true, true, true, false, false, "Correo electrónico" },
                    { 2, true, false, true, true, false, "Teléfono" },
                    { 3, true, false, true, true, true, "WhatsApp" },
                    { 4, true, false, true, false, false, "Otro" }
                });

            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "id", "email", "fecha_creacion", "fecha_modificacion", "password", "rol", "user_name" },
                values: new object[] { 1, "alfonso.coeto@guacamayotech.com", new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(1603), new DateTime(2023, 3, 14, 10, 22, 31, 164, DateTimeKind.Utc).AddTicks(1606), "c12fd9d663f595285f8ebffcb3c9b3144cd6d96f2c3acfa8293162fb701c871739378aa6ab073590d99057ec2a34eec3dd2c30899cce81501bea1837a916c997", "Super Administrador", "poncho.admin" });

            migrationBuilder.InsertData(
                table: "dato_contacto",
                columns: new[] { "id", "activo", "persona_id", "tipo_contacto_id", "valor", "verificado" },
                values: new object[,]
                {
                    { 1, true, 1, 1, "alfonso.coeto@guacamayotech.com", true },
                    { 2, true, 2, 1, "admin@test.com", true }
                });

            migrationBuilder.CreateIndex(
                name: "ix_bajas_sistema_id_persona_id",
                table: "bajas_sistema",
                columns: new[] { "id", "persona_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_bajas_sistema_motivo_baja_id",
                table: "bajas_sistema",
                column: "motivo_baja_id");

            migrationBuilder.CreateIndex(
                name: "ix_bajas_sistema_persona_id",
                table: "bajas_sistema",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "ix_causa_id",
                table: "causa",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_codigo_invitacion_id",
                table: "codigo_invitacion",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_codigo_invitacion_sponsor_id",
                table: "codigo_invitacion",
                column: "sponsor_id");

            migrationBuilder.CreateIndex(
                name: "ix_dato_contacto_id",
                table: "dato_contacto",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_dato_contacto_persona_id",
                table: "dato_contacto",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "ix_dato_contacto_tipo_contacto_id",
                table: "dato_contacto",
                column: "tipo_contacto_id");

            migrationBuilder.CreateIndex(
                name: "ix_direccion_entidad_federativa_id",
                table: "direccion",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_direccion_id_persona_id",
                table: "direccion",
                columns: new[] { "id", "persona_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_direccion_persona_id",
                table: "direccion",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "ix_entidad_federativa_id",
                table: "entidad_federativa",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_entidad_federativa_grupo_entidad_federativa_entidad_federat",
                table: "entidad_federativa_grupo_entidad_federativa",
                column: "entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_entidad_federativa_grupo_entidad_federativa_grupo_entidad_f",
                table: "entidad_federativa_grupo_entidad_federativa",
                column: "grupo_entidad_federativa_id");

            migrationBuilder.CreateIndex(
                name: "ix_entidad_federativa_grupo_entidad_federativa_id",
                table: "entidad_federativa_grupo_entidad_federativa",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_escolaridad_id",
                table: "escolaridad",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_evento_evento_tipo_id",
                table: "evento",
                column: "evento_tipo_id");

            migrationBuilder.CreateIndex(
                name: "ix_evento_id",
                table: "evento",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_evento_responsable_id",
                table: "evento",
                column: "responsable_id");

            migrationBuilder.CreateIndex(
                name: "ix_evento_tipo_id",
                table: "evento_tipo",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_genero_id",
                table: "genero",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_grupo_causa_id",
                table: "grupo_causa",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_grupo_entidad_federativa_id",
                table: "grupo_entidad_federativa",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_grupo_intereses_id",
                table: "grupo_intereses",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_habilidad_id",
                table: "habilidad",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_habilidad_custom_id",
                table: "habilidad_custom",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_habilidad_custom_persona_id",
                table: "habilidad_custom",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "ix_interes_id",
                table: "interes",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_invitado_id",
                table: "invitado",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_motivo_id",
                table: "motivo",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_motivo_baja_id",
                table: "motivo_baja",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_persona_id",
                table: "persona",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_tipo_contacto_id",
                table: "tipo_contacto",
                column: "id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bajas_sistema");

            migrationBuilder.DropTable(
                name: "causa");

            migrationBuilder.DropTable(
                name: "causa_grupo_causa");

            migrationBuilder.DropTable(
                name: "codigo_invitacion");

            migrationBuilder.DropTable(
                name: "dato_contacto");

            migrationBuilder.DropTable(
                name: "direccion");

            migrationBuilder.DropTable(
                name: "entidad_federativa_grupo_entidad_federativa");

            migrationBuilder.DropTable(
                name: "escolaridad");

            migrationBuilder.DropTable(
                name: "evento");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "grupo_causa");

            migrationBuilder.DropTable(
                name: "grupo_intereses");

            migrationBuilder.DropTable(
                name: "habilidad");

            migrationBuilder.DropTable(
                name: "habilidad_custom");

            migrationBuilder.DropTable(
                name: "interes");

            migrationBuilder.DropTable(
                name: "interes_grupo_intereses");

            migrationBuilder.DropTable(
                name: "invitado");

            migrationBuilder.DropTable(
                name: "motivo");

            migrationBuilder.DropTable(
                name: "persona_causa");

            migrationBuilder.DropTable(
                name: "persona_codigo_invitacion");

            migrationBuilder.DropTable(
                name: "persona_escolaridad");

            migrationBuilder.DropTable(
                name: "persona_genero");

            migrationBuilder.DropTable(
                name: "persona_habilidad");

            migrationBuilder.DropTable(
                name: "persona_interes");

            migrationBuilder.DropTable(
                name: "persona_motivo");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "motivo_baja");

            migrationBuilder.DropTable(
                name: "tipo_contacto");

            migrationBuilder.DropTable(
                name: "entidad_federativa");

            migrationBuilder.DropTable(
                name: "grupo_entidad_federativa");

            migrationBuilder.DropTable(
                name: "evento_tipo");

            migrationBuilder.DropTable(
                name: "persona");
        }
    }
}
