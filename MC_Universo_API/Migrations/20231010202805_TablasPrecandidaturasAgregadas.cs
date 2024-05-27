using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasPrecandidaturasAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_tipo_precandidatura",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_tipo_precandidatura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "apoyo_precandidatura",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    tipo_precandidatura_id = table.Column<int>(type: "integer", nullable: false),
                    formulario_rellenado_json = table.Column<string>(type: "text", nullable: false, comment: "Esta columna guarda el formulario llenado en formato JSON"),
                    esta_interesado_informacion_adicional = table.Column<bool>(type: "boolean", nullable: true, comment: "Esta columna indica si el registro esta interesado en recibir mas informacion"),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_apoyo_precandidatura", x => x.id);
                    table.ForeignKey(
                        name: "fk_apoyo_precandidatura_catalogo_tipo_precandidatura_tipo_prec",
                        column: x => x.tipo_precandidatura_id,
                        principalTable: "catalogo_tipo_precandidatura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_apoyo_precandidatura_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "perfil_precandidatura",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    tipo_precandidatura_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_precandidatura", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_precandidatura_catalogo_tipo_precandidatura_tipo_pre",
                        column: x => x.tipo_precandidatura_id,
                        principalTable: "catalogo_tipo_precandidatura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_precandidatura_perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Debido a que solo se puede registrar un tipo de precandidatura por perfil, se establece constraint unique");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(260), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(267), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(269), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(272), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(273), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(275), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(277), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(278), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(279), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(281), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(282), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(283), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(285), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(286), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(287), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(288), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(290), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(291), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(293), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(294), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(296), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(297), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(298), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(299), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(301), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(302), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(303), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(304), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(329), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(330), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(332), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(333), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(334), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(336), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(338), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(339), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(340), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(341), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(343), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(344), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(345), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(346), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(348), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(349), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(350), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(352), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(353), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(354), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(356), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(357), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(358), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(360), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(361), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(362), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(363), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(365), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(366), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(367), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(369), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(370), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(371), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(372), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(374), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(375), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(376), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(378), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(379), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(381), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(382), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(384), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(386), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(387), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(389), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(390), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(391), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(393), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(394), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(395), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(396), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(398), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(399), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(402), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(403), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(404), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(405), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(407), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(408), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(409), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(411), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(412), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(413), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(414), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(416), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(417), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(418), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(441), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(442), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(443), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(445), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(446), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(447), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(449), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(450), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(451), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(452), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(454), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(455), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(456), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(458), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(459), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(460), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(462), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(463), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(464), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(465), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1628), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1647), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1679), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.InsertData(
                table: "catalogo_tipo_precandidatura",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1731), "Diputación Federal" },
                    { 2, true, new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1742), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1742), "Senaduría" },
                    { 3, true, new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1743), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1743), "Titular de la Presidencia de los Estados Unidos Mexicanos" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9181), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9185), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9187), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9188), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9189), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9191), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9192), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9193), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9194), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9195), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9196), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9198), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9199), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9201), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9202), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9203), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9205), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9206), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9207), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9208), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9209), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9211), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9212), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9213), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9214), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9215), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9216), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9217), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9219), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9259), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 10, 20, 28, 5, 106, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(7782), new DateTime(2023, 10, 10, 20, 28, 5, 105, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.CreateIndex(
                name: "ix_apoyo_precandidatura_perfil_id",
                table: "apoyo_precandidatura",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "ix_apoyo_precandidatura_tipo_precandidatura_id",
                table: "apoyo_precandidatura",
                column: "tipo_precandidatura_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_precandidatura_perfil_id",
                table: "perfil_precandidatura",
                column: "perfil_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_perfil_precandidatura_tipo_precandidatura_id",
                table: "perfil_precandidatura",
                column: "tipo_precandidatura_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "apoyo_precandidatura");

            migrationBuilder.DropTable(
                name: "perfil_precandidatura");

            migrationBuilder.DropTable(
                name: "catalogo_tipo_precandidatura");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9183), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9192), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7972), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7974), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7975), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7984), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7985), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7986), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7988), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7991), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7992), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7993), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7995), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7996), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7997), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7999), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8001), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8002), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8003), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8005), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8007), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8011), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8013), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8016), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8019), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8022), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8023), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8025), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8026), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8027), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8028), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8031), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8032), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8034), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8035), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8036), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8038), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8039), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8040), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8041), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8043), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8044), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8045), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8046), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8048), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8049), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8052), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8053), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8054), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8055), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8058), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8059), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8062), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8064), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8065), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8068), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8120), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8121), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8123), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8124), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8125), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8126), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8128), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8129), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8130), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8131), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8133), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8134), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8135), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8137), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8138), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8139), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8142), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8143), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8144), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8146), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8148), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8149), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8151), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8152), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8153), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8155), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8156), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8157), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8159), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8160), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8161), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8162), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8163), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8165), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8166), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8169), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8170), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8171), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8173), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8174), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8175), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8176), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8178), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8179), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9250), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9261), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9347), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9351), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9382), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9387), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9388), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9389), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6887), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6893), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6894), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6895), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6896), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6899), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6901), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6903), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6904), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6916), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6917), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6918), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6919), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6921), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6922), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6923), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6924), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6925), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6927), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6928), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6929), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6931), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6932), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6933), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6935), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6936), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6937), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6975), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7186), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(5617), new DateTime(2023, 10, 9, 17, 7, 27, 292, DateTimeKind.Utc).AddTicks(5622) });
        }
    }
}
