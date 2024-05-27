using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MigracionMerge20230807 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidatos_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_perfil = table.Column<int>(type: "integer", nullable: false),
                    id_camino = table.Column<int>(type: "integer", nullable: false),
                    id_cargo_postulacion = table.Column<int>(type: "integer", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_candidatos_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_candidatos_chc_catalogo_caminos_chc_id_camino",
                        column: x => x.id_camino,
                        principalTable: "catalogo_caminos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_candidatos_chc_catalogo_cargos_postulacion_id_cargo_postula",
                        column: x => x.id_cargo_postulacion,
                        principalTable: "catalogo_cargos_postulacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_candidatos_chc_perfil_id_perfil",
                        column: x => x.id_perfil,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "configuracion_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_configuracion = table.Column<string>(type: "text", nullable: false),
                    tipo_configuracion = table.Column<string>(type: "text", nullable: false),
                    archivo = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_configuracion_chc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contenido_pantallas_etapas_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_camino = table.Column<int>(type: "integer", nullable: false),
                    id_etapa = table.Column<int>(type: "integer", nullable: false),
                    contenido = table.Column<string>(type: "text", nullable: false),
                    fecha_ultimo_cambio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contenido_pantallas_etapas_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_contenido_pantallas_etapas_chc_catalogo_caminos_chc_id_cami",
                        column: x => x.id_camino,
                        principalTable: "catalogo_caminos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_contenido_pantallas_etapas_chc_catalogo_etapas_chc_id_etapa",
                        column: x => x.id_etapa,
                        principalTable: "catalogo_etapas_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "examenes_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_examen = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_examenes_chc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perfil_grupal_catalogo_redes_sociales",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catalogo_redes_sociales_id = table.Column<int>(type: "integer", nullable: false),
                    perfil_grupal_id = table.Column<int>(type: "integer", nullable: false),
                    url = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_grupal_catalogo_redes_sociales", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_catalogo_redes_sociales_catalogo_redes_social",
                        column: x => x.catalogo_redes_sociales_id,
                        principalTable: "catalogo_redes_sociales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_grupal_catalogo_redes_sociales_perfil_grupal_perfil_",
                        column: x => x.perfil_grupal_id,
                        principalTable: "perfil_grupal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "avance_etapas_candidato",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_candidato_chc = table.Column<int>(type: "integer", nullable: false),
                    id_etapa = table.Column<int>(type: "integer", nullable: false),
                    porcentaje_avance = table.Column<int>(type: "integer", nullable: false),
                    valido_comite = table.Column<bool>(type: "boolean", nullable: true),
                    fecha_ultimo_cambio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_avance_etapas_candidato", x => x.id);
                    table.ForeignKey(
                        name: "fk_avance_etapas_candidato_candidatos_chc_id_candidato_chc",
                        column: x => x.id_candidato_chc,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_avance_etapas_candidato_catalogo_etapas_chc_id_etapa",
                        column: x => x.id_etapa,
                        principalTable: "catalogo_etapas_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "documento_candidatos_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_candidato_chc = table.Column<int>(type: "integer", nullable: false),
                    id_documento_eligibilidad_chc = table.Column<int>(type: "integer", nullable: false),
                    id_estatus_documento_eligibilidad_chc = table.Column<int>(type: "integer", nullable: false),
                    nombre_archivo = table.Column<string>(type: "text", nullable: false),
                    motivo_rechazo = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_documento_candidatos_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_documento_candidatos_chc_candidatos_chc_id_candidato_chc",
                        column: x => x.id_candidato_chc,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_documento_candidatos_chc_catalogo_documentos_eligibilidad_c",
                        column: x => x.id_documento_eligibilidad_chc,
                        principalTable: "catalogo_documentos_eligibilidad_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_documento_candidatos_chc_catalogo_estatus_documentos_eligib",
                        column: x => x.id_estatus_documento_eligibilidad_chc,
                        principalTable: "catalogo_estatus_documentos_eligibilidad_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "examenes_candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_examen_chc = table.Column<int>(type: "integer", nullable: false),
                    id_candidato_chc = table.Column<int>(type: "integer", nullable: false),
                    id_candidato_chc1 = table.Column<int>(type: "integer", nullable: false),
                    es_aprobado = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_ultimo_intento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_examenes_candidatos", x => x.id);
                    table.ForeignKey(
                        name: "fk_examenes_candidatos_candidatos_chc_id_candidato_chc",
                        column: x => x.id_candidato_chc1,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_examenes_candidatos_perfil_id_examen_chc",
                        column: x => x.id_examen_chc,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "preguntas_examen_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_examen_chc = table.Column<int>(type: "integer", nullable: false),
                    id_tipo_pregunta = table.Column<int>(type: "integer", nullable: false),
                    pregunta = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_preguntas_examen_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_preguntas_examen_chc_catalogo_tipos_preguntas_id_tipo_pregu",
                        column: x => x.id_tipo_pregunta,
                        principalTable: "catalogo_tipos_preguntas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_preguntas_examen_chc_examenes_chc_id_examen_chc",
                        column: x => x.id_examen_chc,
                        principalTable: "examenes_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respuesta_examen_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_pregunta_examen_chc = table.Column<int>(type: "integer", nullable: false),
                    respuesta = table.Column<string>(type: "text", nullable: false),
                    es_correcta = table.Column<bool>(type: "boolean", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respuesta_examen_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_respuesta_examen_chc_preguntas_examen_chc_id_pregunta_exame",
                        column: x => x.id_pregunta_examen_chc,
                        principalTable: "preguntas_examen_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalle_examenes_candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_examen_candidato = table.Column<int>(type: "integer", nullable: false),
                    id_respuesta_examen_chc = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_detalle_examenes_candidatos", x => x.id);
                    table.ForeignKey(
                        name: "fk_detalle_examenes_candidatos_examenes_candidatos_id_examen_c",
                        column: x => x.id_examen_candidato,
                        principalTable: "examenes_candidatos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_detalle_examenes_candidatos_respuesta_examen_chc_id_respues",
                        column: x => x.id_respuesta_examen_chc,
                        principalTable: "respuesta_examen_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3805), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3810), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3812), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3813), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3815), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3817), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3818), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3820), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3823), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3825), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3826), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3827), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3828), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3830), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3831), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3832), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3835), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3836), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3837), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3843), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3847), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3848), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3852), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3855), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3858), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3859), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3864), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3865), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3866), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3869), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3870), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3871), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3873), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3874), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3875), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3876), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3878), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3879), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3880), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3882), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3883), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3884), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3885), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3887), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3888), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3889), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3892), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3894), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3896), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3897), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3970), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3971), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3973), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3974), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3975), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3977), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3978), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3979), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3980), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3982), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3983), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3984), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3986), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3987), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3988), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3991), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3992), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3994), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3995), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3996), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3997), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3999), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4000), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4001), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4002), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4004), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4005), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4006), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4008), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4009), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4012), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4013), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4014), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4015), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4017), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4018), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4019), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4020), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4022), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4023), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4024), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4026), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1829), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1831), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1835), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1836), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1837), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1839), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1840), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1849), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1851), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1852), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1854), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1857), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1858), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1859), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1860), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1861), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1862), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1863), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1864), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1866), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1867), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1868), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1869), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1870), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.InsertData(
                table: "examenes_chc",
                columns: new[] { "id", "activo", "fecha_alta", "nombre_examen" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4324), "Evaluación sobre la Carta de Bienvenida" },
                    { 2, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4328), "Evaluación carta compromiso" }
                });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1937), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2310), new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 19, 34, 12, 155, DateTimeKind.Utc).AddTicks(9799), new DateTime(2023, 8, 7, 19, 34, 12, 155, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.InsertData(
                table: "preguntas_examen_chc",
                columns: new[] { "id", "activo", "fecha_alta", "id_examen_chc", "id_tipo_pregunta", "pregunta" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4369), 1, 1, "¿Cuál es el objetivo del camino del héroe ciudadan@?" },
                    { 2, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4381), 1, 1, "¿Por qué hay varios caminos al héroe ciudadano?" },
                    { 3, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4383), 1, 1, "¿Si participas en el Camino del Héroe Ciudadano tienes asegurada una candidatura de Movimiento Ciudadano?" },
                    { 4, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4385), 2, 1, "¿Si registro mi información en la plataforma del Camino del Héroe Ciudadano ya no tengo que registrar mi información ante el INE?" },
                    { 5, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4387), 2, 1, "¿Puedo participar en varios caminos para ser considerado en varios procesos de selección de precandidaturas si cumplo con los requisitos de acceso?" }
                });

            migrationBuilder.InsertData(
                table: "respuesta_examen_chc",
                columns: new[] { "id", "activo", "es_correcta", "fecha_alta", "id_pregunta_examen_chc", "respuesta" },
                values: new object[,]
                {
                    { 1, true, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4467), 1, "Encontrar a los mejores perfiles para defender las causas de la ciudadanía y convertirlos en héroes ciudadan@s." },
                    { 2, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4471), 1, "Dar un lugar a las personas para que se conozcan y compitan para divertirse." },
                    { 3, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4473), 1, "No lo sé." },
                    { 4, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4474), 2, "Para permitir que las personas que se registren en un camino avancen más rápido que los que participan en otro." },
                    { 5, true, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4476), 2, "Para revertir la desigualdad que enfrentan en el ejercicio de sus derechos político-electorales algunos grupos en situación de discriminación o vulnerabilidad." },
                    { 6, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4478), 2, "No lo sé." },
                    { 7, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4480), 3, "Sí, tendré una candidatura asegurada cuando comience el proceso de selección de precandidaturas." },
                    { 8, true, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4481), 3, "No, pero tendré elementos que me permitan ser considerado en el proceso de selección de precandidaturas." },
                    { 9, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4483), 3, "No sé." },
                    { 10, true, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4485), 4, "Sí, tengo que cumplir con la entrega de documentos ante el INE como lo estipula la ley." },
                    { 11, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4487), 4, "No, con la información que cargue en la plataforma del Camino del Héroe Ciudadano será suficiente." },
                    { 12, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4488), 4, "No sé." },
                    { 13, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4490), 5, "Sí, puedo participar en diferentes caminos siempre y cuando cumpla con los requisitos de acceso del camino" },
                    { 14, true, true, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4491), 5, "No, solamente puedo participar en un camino ya que existe un camino que contempla a las personas que cumplen varios requisitos de acceso." },
                    { 15, true, false, new DateTime(2023, 8, 7, 19, 34, 12, 156, DateTimeKind.Utc).AddTicks(4492), 5, "No sé." }
                });

            migrationBuilder.CreateIndex(
                name: "ix_avance_etapas_candidato_id_candidato_chc",
                table: "avance_etapas_candidato",
                column: "id_candidato_chc");

            migrationBuilder.CreateIndex(
                name: "ix_avance_etapas_candidato_id_etapa",
                table: "avance_etapas_candidato",
                column: "id_etapa");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_id_camino",
                table: "candidatos_chc",
                column: "id_camino");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_id_cargo_postulacion",
                table: "candidatos_chc",
                column: "id_cargo_postulacion");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_id_perfil",
                table: "candidatos_chc",
                column: "id_perfil");

            migrationBuilder.CreateIndex(
                name: "ix_contenido_pantallas_etapas_chc_id_camino",
                table: "contenido_pantallas_etapas_chc",
                column: "id_camino");

            migrationBuilder.CreateIndex(
                name: "ix_contenido_pantallas_etapas_chc_id_etapa",
                table: "contenido_pantallas_etapas_chc",
                column: "id_etapa");

            migrationBuilder.CreateIndex(
                name: "ix_detalle_examenes_candidatos_id_examen_candidato",
                table: "detalle_examenes_candidatos",
                column: "id_examen_candidato");

            migrationBuilder.CreateIndex(
                name: "ix_detalle_examenes_candidatos_id_respuesta_examen_chc",
                table: "detalle_examenes_candidatos",
                column: "id_respuesta_examen_chc");

            migrationBuilder.CreateIndex(
                name: "ix_documento_candidatos_chc_id_candidato_chc",
                table: "documento_candidatos_chc",
                column: "id_candidato_chc");

            migrationBuilder.CreateIndex(
                name: "ix_documento_candidatos_chc_id_documento_eligibilidad_chc",
                table: "documento_candidatos_chc",
                column: "id_documento_eligibilidad_chc");

            migrationBuilder.CreateIndex(
                name: "ix_documento_candidatos_chc_id_estatus_documento_eligibilidad_",
                table: "documento_candidatos_chc",
                column: "id_estatus_documento_eligibilidad_chc");

            migrationBuilder.CreateIndex(
                name: "ix_examenes_candidatos_id_candidato_chc",
                table: "examenes_candidatos",
                column: "id_candidato_chc1");

            migrationBuilder.CreateIndex(
                name: "ix_examenes_candidatos_id_examen_chc",
                table: "examenes_candidatos",
                column: "id_examen_chc");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_catalogo_redes_sociales_catalogo_redes_social",
                table: "perfil_grupal_catalogo_redes_sociales",
                column: "catalogo_redes_sociales_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_catalogo_redes_sociales_perfil_grupal_id",
                table: "perfil_grupal_catalogo_redes_sociales",
                column: "perfil_grupal_id");

            migrationBuilder.CreateIndex(
                name: "ix_preguntas_examen_chc_id_examen_chc",
                table: "preguntas_examen_chc",
                column: "id_examen_chc");

            migrationBuilder.CreateIndex(
                name: "ix_preguntas_examen_chc_id_tipo_pregunta",
                table: "preguntas_examen_chc",
                column: "id_tipo_pregunta");

            migrationBuilder.CreateIndex(
                name: "ix_respuesta_examen_chc_id_pregunta_examen_chc",
                table: "respuesta_examen_chc",
                column: "id_pregunta_examen_chc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "avance_etapas_candidato");

            migrationBuilder.DropTable(
                name: "configuracion_chc");

            migrationBuilder.DropTable(
                name: "contenido_pantallas_etapas_chc");

            migrationBuilder.DropTable(
                name: "detalle_examenes_candidatos");

            migrationBuilder.DropTable(
                name: "documento_candidatos_chc");

            migrationBuilder.DropTable(
                name: "perfil_grupal_catalogo_redes_sociales");

            migrationBuilder.DropTable(
                name: "examenes_candidatos");

            migrationBuilder.DropTable(
                name: "respuesta_examen_chc");

            migrationBuilder.DropTable(
                name: "candidatos_chc");

            migrationBuilder.DropTable(
                name: "preguntas_examen_chc");

            migrationBuilder.DropTable(
                name: "examenes_chc");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7002), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7007), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7008), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7009), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7010), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7012), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7013), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7014), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7016), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7017), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7018), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7020), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7021), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7022), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7023), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7024), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7025), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7027), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7028), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7029), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7030), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7031), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7033), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7034), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7035), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7036), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7037), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7038), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7039), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7040), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7041), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7043), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7044), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7045), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7081), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7083), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7084), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7085), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7086), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7087), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7088), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7089), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7090), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7091), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7092), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7094), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7095), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7096), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7097), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7098), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7099), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7100), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7101), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7102), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7104), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7105), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7106), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7107), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7108), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7109), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7110), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7111), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7112), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7114), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7116), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7117), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7118), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7119), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7121), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7122), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7123), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7124), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7125), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7126), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7127), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7128), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7129), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7130), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7131), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7133), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7134), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7135), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7136), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7137), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7138), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7139), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7141), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7142), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7143), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7145), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7146), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7147), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7148), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7149), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7151), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7152), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7153), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7154), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7156), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7157), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7158), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7159), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7160), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7161), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7162), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5638), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5649), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5651), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5652), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5653), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5655), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5656), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5657), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5658), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5660), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5661), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5662), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5663), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5664), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5665), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5666), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5667), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5669), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5670), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5671), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5672), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5673), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5674), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5675), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5676), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5677), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5678), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5679), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5680), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5681), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5682), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5683), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5730), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5942), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(4195), new DateTime(2023, 8, 7, 5, 3, 40, 482, DateTimeKind.Utc).AddTicks(4199) });
        }
    }
}
