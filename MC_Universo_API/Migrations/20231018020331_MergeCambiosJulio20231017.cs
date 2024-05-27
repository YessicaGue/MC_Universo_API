using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeCambiosJulio20231017 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_detalle_requisito_diputaciones_entidad_federativa_entidad_id",
                table: "detalle_requisito_diputaciones");

            migrationBuilder.RenameColumn(
                name: "entidad_id",
                table: "detalle_requisito_diputaciones",
                newName: "estado_circunscripcion_id");

            migrationBuilder.RenameIndex(
                name: "ix_detalle_requisito_diputaciones_entidad_id",
                table: "detalle_requisito_diputaciones",
                newName: "ix_detalle_requisito_diputaciones_estado_circunscripcion_id");

            migrationBuilder.AddColumn<int>(
                name: "anio_eleccion",
                table: "distritos_federales",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bloque_concentracion_indigena",
                table: "distritos_federales",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mc_competitividad",
                table: "distritos_federales",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "mc_porcentaje",
                table: "distritos_federales",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "candidatos_senador_mayoria_relativa",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "candidatos_senador_primera_minoria",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "candidatos_senador_representacion_proporcional",
                table: "detalle_requisito_diputaciones",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "es_acciones_afirmativas",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "catalogo_nivel_cargo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_nivel = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_nivel_cargo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "circunscripcion_estado",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    circuncripcion_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_circunscripcion_estado", x => x.id);
                    table.ForeignKey(
                        name: "fk_circunscripcion_estado_entidad_federativa_circuncripcion_id",
                        column: x => x.circuncripcion_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_circunscripcion_estado_entidad_federativa_entidad_id",
                        column: x => x.entidad_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "datos_esperados_por_tipo_candidatura",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catalogo_representante_id = table.Column<int>(type: "integer", nullable: false),
                    candidatos_totales = table.Column<int>(type: "integer", nullable: false),
                    cantidad_mujeres = table.Column<int>(type: "integer", nullable: false),
                    cantidad_hombres = table.Column<int>(type: "integer", nullable: false),
                    cantidad_adscripcion_indigena = table.Column<int>(type: "integer", nullable: false),
                    cantidad_diversidad_sexual = table.Column<int>(type: "integer", nullable: false),
                    cantidad_afromexicanos = table.Column<int>(type: "integer", nullable: false),
                    cantidad_discapacitados = table.Column<int>(type: "integer", nullable: false),
                    cantidad_persona_migrante = table.Column<int>(type: "integer", nullable: false),
                    cantidad_persona_joven = table.Column<int>(type: "integer", nullable: false),
                    cantidad_persona_mayor = table.Column<int>(type: "integer", nullable: false),
                    anio_elecciones = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_datos_esperados_por_tipo_candidatura", x => x.id);
                    table.ForeignKey(
                        name: "fk_datos_esperados_por_tipo_candidatura_catalogo_representante",
                        column: x => x.catalogo_representante_id,
                        principalTable: "catalogo_representante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "requisito_por_circunscripcion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cicunscripcion_id = table.Column<int>(type: "integer", nullable: false),
                    representante_id = table.Column<int>(type: "integer", nullable: false),
                    lugares_disponibles = table.Column<int>(type: "integer", nullable: false),
                    cantidad_identificacion_indigena = table.Column<int>(type: "integer", nullable: false),
                    anio_eleccion = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_requisito_por_circunscripcion", x => x.id);
                    table.ForeignKey(
                        name: "fk_requisito_por_circunscripcion_catalogo_circunscripcion_cicu",
                        column: x => x.cicunscripcion_id,
                        principalTable: "catalogo_circunscripcion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_requisito_por_circunscripcion_catalogo_representante_repres",
                        column: x => x.representante_id,
                        principalTable: "catalogo_representante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2385), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2393), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(699), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(708), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(709), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(711), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(714), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(716), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(718), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(719), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(721), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(722), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(724), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(727), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(728), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(729), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(733), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(734), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(736), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(737), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(738), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(740), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(741), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(743), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(745), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(746), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(752), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(753), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(756), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(757), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(758), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(760), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(763), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(765), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(766), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(767), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(770), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(771), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(773), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(774), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(775), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(777), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(778), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(779), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(780), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(782), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(783), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(785), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(786), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(787), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(789), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(790), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(791), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(793), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(794), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(801), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(803), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(805), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(806), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(807), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(809), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(810), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(812), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(813), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(814), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(816), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(817), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(818), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(819), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(821), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(822), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(823), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(825), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(826), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(828), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(829), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(830), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(831), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(833), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(834), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(835), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(837), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(838), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(839), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(841), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(842), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(845), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(846), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(847), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(849), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(850), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(851), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(853), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(854), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(856), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(858), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(859), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(862), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(865), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(866), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(868), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(869), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(871), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2425), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2460), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2464), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2465), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2492), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2497), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2562), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2566), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2567), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2523), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2525), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2527), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.InsertData(
                table: "datos_esperados_por_tipo_candidatura",
                columns: new[] { "id", "activo", "anio_elecciones", "candidatos_totales", "cantidad_adscripcion_indigena", "cantidad_afromexicanos", "cantidad_discapacitados", "cantidad_diversidad_sexual", "cantidad_hombres", "cantidad_mujeres", "cantidad_persona_joven", "cantidad_persona_mayor", "cantidad_persona_migrante", "catalogo_representante_id", "fecha_creacion" },
                values: new object[,]
                {
                    { 1, true, 2024, 200, 11, 1, 1, 2, 0, 0, 0, 0, 5, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1544) },
                    { 2, true, 2024, 300, 18, 3, 6, 2, 0, 0, 0, 0, 0, 2, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1547) },
                    { 3, true, 2024, 64, 5, 1, 1, 1, 32, 32, 0, 0, 0, 3, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1549) },
                    { 4, true, 2024, 32, 5, 1, 1, 1, 16, 16, 0, 0, 0, 4, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1552) },
                    { 5, true, 2024, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1553) }
                });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 9, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 8, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 22, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 8, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 40, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 11, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 14, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 16, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 6, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 8, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 19, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 6, 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "candidatos_senador_mayoria_relativa", "candidatos_senador_primera_minoria", "candidatos_senador_representacion_proporcional", "fecha_creacion" },
                values: new object[] { 2, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1692), "MEDIA", 3.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1699), "MEDIA", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1701), "MEDIA", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1703), "ALTA", 7.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1705), "MEDIA", 5.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1706), "MEDIA", 4.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1708), "MEDIA", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1709), "MEDIA", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1715), "MEDIA", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1717), "MEDIA", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1719), "MEDIA", 4.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1720), "MEDIA", 5.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1722), "MEDIA", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1723), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1725), "ALTA", 22.899999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1727), "ALTA", 15.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1728), "BAJA", 1.8 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1730), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1732), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1733), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1734), "BAJA", 0.90000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1736), "BAJA", 1.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1737), "BAJA", 1.8 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1739), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1740), "ALTA", 18.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1742), "ALTA", 7.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1743), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1745), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1746), "BAJA", 1.7 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1747), "BAJA", 1.8 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1759), "MEDIA", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1760), "MEDIA", 5.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1762), "BAJA", 2.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1764), "MEDIA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1765), "ALTA", 11.699999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1767), "MEDIA", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1768), "BAJA", 1.7 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1770), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1771), "BAJA", 2.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1773), "ALTA", 8.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1774), "MEDIA", 5.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1775), "ALTA", 7.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1777), "ALTA", 6.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1778), "ALTA", 11.4 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1780), "ALTA", 6.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1781), "ALTA", 7.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1783), "ALTA", 6.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1784), "ALTA", 17.100000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1786), "BAJA", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1787), "BAJA", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1789), "BAJA", 2.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1790), "MEDIA", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1791), "ALTA", 7.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1793), "MEDIA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1794), "MEDIA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1796), "MEDIA", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1797), "BAJA", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1799), "MEDIA", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1800), "MEDIA", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1802), "MEDIA", 3.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1803), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1804), "ALTA", 6.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1806), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1807), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1809), "BAJA", 3.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1818), "MEDIA", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1819), "BAJA", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1821), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1822), "MEDIA", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1824), "BAJA", 3.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1830), "MEDIA", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1831), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1833), "MEDIA", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1834), "ALTA", 10.800000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1836), "BAJA", 1.7 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1837), "MEDIA", 5.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1839), "MEDIA", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1840), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1841), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1843), "MEDIA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1844), "MEDIA", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1846), "ALTA", 8.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1848), "MEDIA", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1849), "ALTA", 8.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1851), "BAJA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1852), "MEDIA", 4.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1854), "MEDIA", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1855), "ALTA", 6.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1857), "MEDIA", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1858), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1859), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1861), "BAJA", 1.8 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1862), "ALTA", 5.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1864), "MEDIA", 5.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1866), "MEDIA", 4.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1867), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1869), "BAJA", 1.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1870), "BAJA", 1.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1871), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1873), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1874), "BAJA", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1876), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1877), "BAJA", 2.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1879), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1880), "ALTA", 30.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1881), "ALTA", 33.700000000000003 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1883), "ALTA", 25.800000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1884), "ALTA", 36.600000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1886), "ALTA", 28.600000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1887), "ALTA", 40.899999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1889), "ALTA", 22.399999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1890), "ALTA", 39.799999999999997 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1891), "ALTA", 32.100000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1893), "ALTA", 44.700000000000003 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1894), "ALTA", 32.700000000000003 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1896), "ALTA", 38.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1897), "ALTA", 31.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1899), "ALTA", 37.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1901), "ALTA", 25.600000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1902), "ALTA", 25.699999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1903), "ALTA", 27.699999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1905), "ALTA", 29.800000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1906), "ALTA", 32.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1908), "ALTA", 30.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1909), "MEDIA", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1911), "MEDIA", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1912), "ALTA", 7.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1913), "MEDIA", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1915), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1922), "ALTA", 6.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1923), "MEDIA", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1925), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1926), "ALTA", 8.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1928), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1929), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1931), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1932), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1933), "BAJA", 1.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1935), "BAJA", 3.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1936), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1938), "ALTA", 11.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1939), "MEDIA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1941), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1942), "MEDIA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1943), "ALTA", 7.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1945), "MEDIA", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1946), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1948), "MEDIA", 5.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1949), "BAJA", 1.7 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1951), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1952), "ALTA", 6.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1953), "BAJA", 2.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1955), "ALTA", 21.800000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1956), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1958), "ALTA", 21.899999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1960), "MEDIA", 3.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1961), "MEDIA", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1963), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1964), "ALTA", 7.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1965), "BAJA", 2.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1967), "ALTA", 6.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1968), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1970), "BAJA", 2.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1971), "MEDIA", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1973), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1974), "MEDIA", 4.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1975), "MEDIA", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1977), "ALTA", 6.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1978), "ALTA", 7.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1980), "ALTA", 6.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1981), "MEDIA", 5.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1983), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1984), "BAJA", 1.7 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1986), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1987), "BAJA", 2.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1989), "MEDIA", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1991), "ALTA", 7.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1992), "ALTA", 9.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1994), "ALTA", 6.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1995), "ALTA", 8.8000000000000007 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1997), "ALTA", 20.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1998), "ALTA", 16.100000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1999), "ALTA", 13.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2001), "ALTA", 14.6 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2002), "ALTA", 20.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2004), "ALTA", 26.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2005), "ALTA", 18.300000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2007), "ALTA", 20.800000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2008), "ALTA", 22.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2010), "ALTA", 27.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2017), "ALTA", 21.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2019), "ALTA", 11.1 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2020), "ALTA", 22.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2022), "ALTA", 18.399999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2023), "ALTA", 24.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2025), "ALTA", 24.100000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2026), "ALTA", 14.199999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2027), "MEDIA", 4.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2029), "BAJA", 2.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2030), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2032), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2033), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2035), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2036), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2038), "MEDIA", 4.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2039), "BAJA", 1.8 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2040), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2042), "ALTA", 10.699999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2043), "MEDIA", 3.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2045), "ALTA", 8.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2046), "ALTA", 11.300000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2048), "ALTA", 7.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2049), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2050), "ALTA", 6.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2052), "ALTA", 8.1999999999999993 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2053), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2055), "MEDIA", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2056), "BAJA", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2058), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2059), "MEDIA", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2061), "MEDIA", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2062), "MEDIA", 5.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2063), "MEDIA", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2066), "BAJA", 1.7 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2067), "BAJA", 1.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2069), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2070), "BAJA", 1.8 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2072), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2073), "BAJA", 2.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2074), "MEDIA", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2076), "MEDIA", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2077), "BAJA", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2079), "MEDIA", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2080), "ALTA", 8.6999999999999993 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2082), "MEDIA", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2083), "ALTA", 7.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2084), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2086), "BAJA", 3.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2087), "MEDIA", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2089), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2090), "ALTA", 6.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2091), "MEDIA", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2093), "MEDIA", 4.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2094), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2096), "MEDIA", 4.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2097), "MEDIA", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2099), "MEDIA", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2100), "MEDIA", 5.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2102), "ALTA", 6.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2103), "ALTA", 12.4 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2104), "ALTA", 7.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2106), "ALTA", 7.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2107), "ALTA", 12.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2109), "MEDIA", 5.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2110), "BAJA", 1.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2112), "BAJA", 1.3 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2113), "BAJA", 3.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2121), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2122), "MEDIA", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2124), "ALTA", 8.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2125), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2127), "MEDIA", 3.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2128), "BAJA", 2.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2130), "BAJA", 2.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2131), "MEDIA", 4.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2132), "MEDIA", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2134), "BAJA", 2.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2135), "BAJA", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2137), "BAJA", 2.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2138), "MEDIA", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2140), "MEDIA", 5.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2141), "BAJA", 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2143), "MEDIA", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2145), "MEDIA", 5.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2146), "MEDIA", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2148), "MEDIA", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2149), "ALTA", 13.4 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2151), "ALTA", 6.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2152), "ALTA", 13.300000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2154), "ALTA", 8.8000000000000007 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2155), "ALTA", 7.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2156), "MEDIA", 5.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2158), "MEDIA", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2159), "ALTA", 10.1 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2161), "MEDIA", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2162), "ALTA", 8.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2164), "ALTA", 6.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2165), "ALTA", 11.4 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2166), "MEDIA", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2168), "ALTA", 13.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2169), "BAJA", 1.2 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2171), "MEDIA", 4.5 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2172), "BAJA", 1.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2174), "BAJA", 2.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "ALTA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2175), "MEDIA", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2177), "BAJA", 3.0 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "MEDIA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2178), "BAJA", 2.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2179), "MEDIA", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2181), "MEDIA", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                columns: new[] { "anio_eleccion", "bloque_concentracion_indigena", "fecha_creacion", "mc_competitividad", "mc_porcentaje" },
                values: new object[] { 2024, "BAJA", new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2188), "MEDIA", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9461), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9462), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9464), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9471), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9472), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9487), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9488), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9489), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9491), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9493), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9494), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9495), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9496), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9497), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9498), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9499), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9502), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9503), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9504), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9505), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9506), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9508), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9818), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.InsertData(
                table: "requisito_por_circunscripcion",
                columns: new[] { "id", "activo", "anio_eleccion", "cantidad_identificacion_indigena", "cicunscripcion_id", "fecha_creacion", "lugares_disponibles", "representante_id" },
                values: new object[,]
                {
                    { 1, true, 2024, 1, 1, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2593), 40, 1 },
                    { 2, true, 2024, 1, 2, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2598), 40, 1 },
                    { 3, true, 2024, 4, 3, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2600), 40, 1 },
                    { 4, true, 2024, 2, 4, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2601), 40, 1 },
                    { 5, true, 2024, 1, 5, new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(2602), 40, 1 }
                });

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 2, 3, 30, 922, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(8183), new DateTime(2023, 10, 18, 2, 3, 30, 921, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.CreateIndex(
                name: "ix_circunscripcion_estado_circuncripcion_id",
                table: "circunscripcion_estado",
                column: "circuncripcion_id");

            migrationBuilder.CreateIndex(
                name: "ix_circunscripcion_estado_entidad_id",
                table: "circunscripcion_estado",
                column: "entidad_id");

            migrationBuilder.CreateIndex(
                name: "ix_datos_esperados_por_tipo_candidatura_catalogo_representante",
                table: "datos_esperados_por_tipo_candidatura",
                column: "catalogo_representante_id");

            migrationBuilder.CreateIndex(
                name: "ix_requisito_por_circunscripcion_cicunscripcion_id",
                table: "requisito_por_circunscripcion",
                column: "cicunscripcion_id");

            migrationBuilder.CreateIndex(
                name: "ix_requisito_por_circunscripcion_representante_id",
                table: "requisito_por_circunscripcion",
                column: "representante_id");

            migrationBuilder.AddForeignKey(
                name: "fk_detalle_requisito_diputaciones_estado_circunscripcion_estad",
                table: "detalle_requisito_diputaciones",
                column: "estado_circunscripcion_id",
                principalTable: "estado_circunscripcion",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_detalle_requisito_diputaciones_estado_circunscripcion_estad",
                table: "detalle_requisito_diputaciones");

            migrationBuilder.DropTable(
                name: "catalogo_nivel_cargo");

            migrationBuilder.DropTable(
                name: "circunscripcion_estado");

            migrationBuilder.DropTable(
                name: "datos_esperados_por_tipo_candidatura");

            migrationBuilder.DropTable(
                name: "requisito_por_circunscripcion");

            migrationBuilder.DropColumn(
                name: "anio_eleccion",
                table: "distritos_federales");

            migrationBuilder.DropColumn(
                name: "bloque_concentracion_indigena",
                table: "distritos_federales");

            migrationBuilder.DropColumn(
                name: "mc_competitividad",
                table: "distritos_federales");

            migrationBuilder.DropColumn(
                name: "mc_porcentaje",
                table: "distritos_federales");

            migrationBuilder.DropColumn(
                name: "candidatos_senador_mayoria_relativa",
                table: "detalle_requisito_diputaciones");

            migrationBuilder.DropColumn(
                name: "candidatos_senador_primera_minoria",
                table: "detalle_requisito_diputaciones");

            migrationBuilder.DropColumn(
                name: "candidatos_senador_representacion_proporcional",
                table: "detalle_requisito_diputaciones");

            migrationBuilder.DropColumn(
                name: "es_acciones_afirmativas",
                table: "candidatos_chc");

            migrationBuilder.RenameColumn(
                name: "estado_circunscripcion_id",
                table: "detalle_requisito_diputaciones",
                newName: "entidad_id");

            migrationBuilder.RenameIndex(
                name: "ix_detalle_requisito_diputaciones_estado_circunscripcion_id",
                table: "detalle_requisito_diputaciones",
                newName: "ix_detalle_requisito_diputaciones_entidad_id");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6559), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6574), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6575), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5228), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5235), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5236), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5238), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5239), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5241), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5243), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5245), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5246), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5247), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5249), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5251), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5253), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5254), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5255), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5256), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5258), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5261), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5262), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5264), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5265), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5266), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5268), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5269), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5270), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5271), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5272), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5274), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5275), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5277), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5278), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5280), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5281), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5283), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5284), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5285), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5286), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5288), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5289), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5292), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5293), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5294), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5303), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5305), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5306), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5308), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5309), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5310), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5311), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5313), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5314), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5315), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5316), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5318), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5319), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5321), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5322), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5323), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5326), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5327), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5329), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5331), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5333), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5335), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5336), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5338), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5339), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5342), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5344), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5346), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5348), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5351), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5352), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5354), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5355), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5356), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5358), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5359), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5362), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5363), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5364), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5365), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5369), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5371), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5372), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5373), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5375), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5376), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5377), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5379), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5380), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5381), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5383), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5384), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5385), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5387), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5388), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5389), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5391), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5393), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5394), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5397), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6702), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6706), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6779), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6799), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6735), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6738), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6739), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6740), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 8, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 7, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 24, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 9, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 41, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 12, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 12, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 15, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 5, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 9, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 20, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "candidatos_diputados_mayoria_relativa", "fecha_creacion" },
                values: new object[] { 5, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3809), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3813), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3814), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3816), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3817), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3818), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3820), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3822), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3823), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3824), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3832), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3833), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3834), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3836), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3837), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3838), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3841), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3843), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3845), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3847), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3848), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3850), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3852), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3911), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4191), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(2365), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.AddForeignKey(
                name: "fk_detalle_requisito_diputaciones_entidad_federativa_entidad_id",
                table: "detalle_requisito_diputaciones",
                column: "entidad_id",
                principalTable: "entidad_federativa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
