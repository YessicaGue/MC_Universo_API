using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20231005 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_perfil_perfil_id",
                table: "candidatos_chc");

            migrationBuilder.AddColumn<bool>(
                name: "en_circulo",
                table: "perfil_sigue_perfil",
                type: "boolean",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "perfil_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<bool>(
                name: "afromexicanas",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "circunscripcion_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "con_discapacidad",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "dato_de_prueba",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "distrito_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "diversidad_sexual",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "en_pobreza",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "es_suplente",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "estado_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "identificacion_indigena",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "mexicanos_migrantes",
                table: "candidatos_chc",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "representante_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "candidato_persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    candidato_id = table.Column<int>(type: "integer", nullable: false),
                    persona_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_candidato_persona", x => x.id);
                    table.ForeignKey(
                        name: "fk_candidato_persona_candidatos_chc_candidato_id",
                        column: x => x.candidato_id,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_candidato_persona_persona_persona_id",
                        column: x => x.persona_id,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_circunscripcion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    circunscripcion = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_circunscripcion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catalogo_representante",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_cargo = table.Column<string>(type: "text", nullable: false),
                    principio = table.Column<string>(type: "text", nullable: true),
                    nivel_cargo = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_representante", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "detalle_requisito_diputaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    entidad_id = table.Column<int>(type: "integer", nullable: false),
                    candidatos_diputados_mayoria_relativa = table.Column<int>(type: "integer", nullable: true),
                    formulas_mayoria_relativa = table.Column<int>(type: "integer", nullable: true),
                    candidatos_diputados_representacion_proporcional = table.Column<int>(type: "integer", nullable: true),
                    formulas_representacion_proporcional = table.Column<int>(type: "integer", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_detalle_requisito_diputaciones", x => x.id);
                    table.ForeignKey(
                        name: "fk_detalle_requisito_diputaciones_entidad_federativa_entidad_id",
                        column: x => x.entidad_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "distritos_federales",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    circunscripcion_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_id = table.Column<int>(type: "integer", nullable: false),
                    distrito = table.Column<int>(type: "integer", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_distritos_federales", x => x.id);
                    table.ForeignKey(
                        name: "fk_distritos_federales_catalogo_circunscripcion_circunscripcio",
                        column: x => x.circunscripcion_id,
                        principalTable: "catalogo_circunscripcion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_distritos_federales_entidad_federativa_entidad_id",
                        column: x => x.entidad_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "estado_circunscripcion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    circunscripcion_id = table.Column<int>(type: "integer", nullable: false),
                    entidad_id = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_estado_circunscripcion", x => x.id);
                    table.ForeignKey(
                        name: "fk_estado_circunscripcion_catalogo_circunscripcion_circunscrip",
                        column: x => x.circunscripcion_id,
                        principalTable: "catalogo_circunscripcion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_estado_circunscripcion_entidad_federativa_entidad_id",
                        column: x => x.entidad_id,
                        principalTable: "entidad_federativa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.InsertData(
                table: "catalogo_circunscripcion",
                columns: new[] { "id", "activo", "circunscripcion", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2372), "Circunscripcion 1" },
                    { 2, true, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2380), "Circunscripcion 2" },
                    { 3, true, 3, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2381), "Circunscripcion 3" },
                    { 4, true, 4, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2382), "Circunscripcion 4" },
                    { 5, true, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2383), "Circunscripcion 5" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1563), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1566), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1568), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1570), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1575), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1579), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1581), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1582), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1587), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1589), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1593), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1596), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1598), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1606), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1608), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1610), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1611), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1612), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1615), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1617), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1619), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1620), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1621), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1623), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1625), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1627), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1628), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1629), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1636), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1637), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1639), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1640), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1641), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1643), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1644), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1645), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1647), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1648), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1649), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1654), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1655), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1656), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1658), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1659), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1660), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1662), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1663), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1665), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1666), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1668), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1684), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1685), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1686), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1688), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1689), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1690), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1692), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1693), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1694), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1696), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1697), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1698), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1700), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1701), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1703), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1705), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1710), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1712), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1713), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1714), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1715), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1718), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1719), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1722), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1723), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1725), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1726), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1727), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1728), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1730), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1731), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1734), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1735), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.InsertData(
                table: "catalogo_representante",
                columns: new[] { "id", "activo", "fecha_creacion", "nivel_cargo", "nombre_cargo", "principio" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3062), "Federal", "Diputación", "Representación Proporcional" },
                    { 2, true, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3067), "Federal", "Diputación", "Mayoría Relativa" },
                    { 3, true, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3068), "Federal", "Senaduría", "Representación Proporcional" },
                    { 4, true, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3069), "Federal", "Senaduría", "Mayoría Relativa" },
                    { 5, true, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3070), "Federal", "Senaduría", "Primera Minoria" }
                });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.InsertData(
                table: "detalle_requisito_diputaciones",
                columns: new[] { "id", "activo", "candidatos_diputados_mayoria_relativa", "candidatos_diputados_representacion_proporcional", "entidad_id", "fecha_creacion", "formulas_mayoria_relativa", "formulas_representacion_proporcional" },
                values: new object[,]
                {
                    { 1, true, 3, 3, 1, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2429), 1, 2 },
                    { 2, true, 8, 5, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2438), 1, 1 },
                    { 3, true, 2, 2, 3, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2439), 1, 1 },
                    { 4, true, 2, 2, 4, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2441), 4, 3 },
                    { 5, true, 7, 4, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2442), 1, 2 },
                    { 6, true, 2, 3, 6, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2444), 1, 5 },
                    { 7, true, 13, 5, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2445), 4, 3 },
                    { 8, true, 9, 5, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2447), 1, 1 },
                    { 9, true, 24, 23, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2448), 2, 4 },
                    { 10, true, 4, 1, 10, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2450), 1, 1 },
                    { 11, true, 15, 4, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2451), 1, 2 },
                    { 12, true, 9, 3, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2452), 2, 4 },
                    { 13, true, 7, 3, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2454), 1, 5 },
                    { 14, true, 20, 11, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2455), 1, 1 },
                    { 15, true, 41, 25, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2456), 1, 5 },
                    { 16, true, 12, 9, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2457), 1, 5 },
                    { 17, true, 5, 4, 17, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2459), 2, 4 },
                    { 18, true, 3, 5, 18, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2460), 1, 1 },
                    { 19, true, 12, 9, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2461), 1, 2 },
                    { 20, true, 10, 10, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2463), 4, 3 },
                    { 21, true, 15, 7, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2464), 2, 4 },
                    { 22, true, 5, 3, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2465), 1, 3 },
                    { 23, true, 4, 3, 23, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2466), 4, 2 },
                    { 24, true, 7, 8, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2468), 1, 1 },
                    { 25, true, 7, 6, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2469), 1, 1 },
                    { 26, true, 7, 5, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2470), 1, 3 },
                    { 27, true, 6, 2, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2471), 4, 2 },
                    { 28, true, 9, 2, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2473), 1, 4 },
                    { 29, true, 3, 3, 29, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2474), 2, 3 },
                    { 30, true, 20, 16, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2475), 4, 3 },
                    { 31, true, 5, 2, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2476), 4, 2 },
                    { 32, true, 4, 7, 32, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2478), 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9996), new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(4), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(5), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(6), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(7), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(9), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(12), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(13), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(22), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(30), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(31), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(33), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(35), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(36), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(37), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(38), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(41), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(42), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(43), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(105), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(337), new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(8571), new DateTime(2023, 10, 5, 18, 29, 6, 150, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.InsertData(
                table: "distritos_federales",
                columns: new[] { "id", "activo", "circunscripcion_id", "distrito", "entidad_id", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, 2, 1, 1, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2533), "Distrito 1" },
                    { 2, true, 2, 2, 1, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2540), "Distrito 2" },
                    { 3, true, 2, 3, 1, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2541), "Distrito 3" },
                    { 4, true, 1, 1, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2542), "Distrito 1" },
                    { 5, true, 1, 2, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2543), "Distrito 2" },
                    { 6, true, 1, 3, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2545), "Distrito 3" },
                    { 7, true, 1, 4, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2546), "Distrito 4" },
                    { 8, true, 1, 5, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2547), "Distrito 5" },
                    { 9, true, 1, 6, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2548), "Distrito 6" },
                    { 10, true, 1, 7, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2549), "Distrito 7" },
                    { 11, true, 1, 8, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2550), "Distrito 8" },
                    { 12, true, 1, 9, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2551), "Distrito 9" },
                    { 13, true, 1, 1, 3, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2552), "Distrito 1" },
                    { 14, true, 1, 2, 3, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2553), "Distrito 2" },
                    { 15, true, 3, 1, 4, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2554), "Distrito 1" },
                    { 16, true, 3, 2, 4, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2555), "Distrito 2" },
                    { 17, true, 2, 1, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2556), "Distrito 1" },
                    { 18, true, 2, 2, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2557), "Distrito 2" },
                    { 19, true, 2, 3, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2558), "Distrito 3" },
                    { 20, true, 2, 4, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2559), "Distrito 4" },
                    { 21, true, 2, 5, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2560), "Distrito 5" },
                    { 22, true, 2, 6, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2561), "Distrito 6" },
                    { 23, true, 2, 7, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2562), "Distrito 7" },
                    { 24, true, 2, 8, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2563), "Distrito 8" },
                    { 25, true, 5, 1, 6, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2564), "Distrito 1" },
                    { 26, true, 5, 2, 6, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2565), "Distrito 2" },
                    { 27, true, 3, 1, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2566), "Distrito 1" },
                    { 28, true, 3, 2, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2567), "Distrito 2" },
                    { 29, true, 3, 3, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2575), "Distrito 3" },
                    { 30, true, 3, 4, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2576), "Distrito 4" },
                    { 31, true, 3, 5, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2577), "Distrito 5" },
                    { 32, true, 3, 6, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2578), "Distrito 6" },
                    { 33, true, 3, 7, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2579), "Distrito 7" },
                    { 34, true, 3, 8, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2580), "Distrito 8" },
                    { 35, true, 3, 9, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2581), "Distrito 9" },
                    { 36, true, 3, 10, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2582), "Distrito 10" },
                    { 37, true, 3, 11, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2583), "Distrito 11" },
                    { 38, true, 3, 12, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2584), "Distrito 12" },
                    { 39, true, 3, 13, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2585), "Distrito 13" },
                    { 40, true, 1, 1, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2585), "Distrito 1" },
                    { 41, true, 1, 2, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2586), "Distrito 2" },
                    { 42, true, 1, 3, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2587), "Distrito 3" },
                    { 43, true, 1, 4, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2588), "Distrito 4" },
                    { 44, true, 1, 5, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2589), "Distrito 5" },
                    { 45, true, 1, 6, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2590), "Distrito 6" },
                    { 46, true, 1, 7, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2591), "Distrito 7" },
                    { 47, true, 1, 8, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2592), "Distrito 8" },
                    { 48, true, 1, 9, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2593), "Distrito 9" },
                    { 49, true, 4, 1, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2594), "Distrito 1" },
                    { 50, true, 4, 2, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2595), "Distrito 2" },
                    { 51, true, 4, 3, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2596), "Distrito 3" },
                    { 52, true, 4, 4, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2596), "Distrito 4" },
                    { 53, true, 4, 5, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2597), "Distrito 5" },
                    { 54, true, 4, 6, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2598), "Distrito 6" },
                    { 55, true, 4, 7, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2599), "Distrito 7" },
                    { 56, true, 4, 8, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2600), "Distrito 8" },
                    { 57, true, 4, 9, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2601), "Distrito 9" },
                    { 58, true, 4, 10, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2602), "Distrito 10" },
                    { 59, true, 4, 11, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2603), "Distrito 11" },
                    { 60, true, 4, 12, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2604), "Distrito 12" },
                    { 61, true, 4, 13, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2605), "Distrito 13" },
                    { 62, true, 4, 14, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2606), "Distrito 14" },
                    { 63, true, 4, 15, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2607), "Distrito 15" },
                    { 64, true, 4, 16, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2608), "Distrito 16" },
                    { 65, true, 4, 17, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2608), "Distrito 17" },
                    { 66, true, 4, 18, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2610), "Distrito 18" },
                    { 67, true, 4, 19, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2611), "Distrito 19" },
                    { 68, true, 4, 20, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2612), "Distrito 20" },
                    { 69, true, 4, 21, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2613), "Distrito 21" },
                    { 70, true, 4, 22, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2613), "Distrito 22" },
                    { 71, true, 1, 1, 10, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2615), "Distrito 1" },
                    { 72, true, 1, 2, 10, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2616), "Distrito 2" },
                    { 73, true, 1, 3, 10, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2617), "Distrito 3" },
                    { 74, true, 1, 4, 10, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2618), "Distrito 4" },
                    { 75, true, 2, 1, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2619), "Distrito 1" },
                    { 76, true, 2, 2, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2620), "Distrito 2" },
                    { 77, true, 2, 3, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2621), "Distrito 3" },
                    { 78, true, 2, 4, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2622), "Distrito 4" },
                    { 79, true, 2, 5, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2623), "Distrito 5" },
                    { 80, true, 2, 6, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2624), "Distrito 6" },
                    { 81, true, 2, 7, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2625), "Distrito 7" },
                    { 82, true, 2, 8, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2626), "Distrito 8" },
                    { 83, true, 2, 9, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2627), "Distrito 9" },
                    { 84, true, 2, 10, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2628), "Distrito 10" },
                    { 85, true, 2, 11, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2629), "Distrito 11" },
                    { 86, true, 2, 12, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2629), "Distrito 12" },
                    { 87, true, 2, 13, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2630), "Distrito 13" },
                    { 88, true, 2, 14, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2631), "Distrito 14" },
                    { 89, true, 2, 15, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2632), "Distrito 15" },
                    { 90, true, 4, 1, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2633), "Distrito 1" },
                    { 91, true, 4, 2, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2634), "Distrito 2" },
                    { 92, true, 4, 3, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2635), "Distrito 3" },
                    { 93, true, 4, 4, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2636), "Distrito 4" },
                    { 94, true, 4, 5, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2637), "Distrito 5" },
                    { 95, true, 4, 6, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2638), "Distrito 6" },
                    { 96, true, 4, 7, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2639), "Distrito 7" },
                    { 97, true, 4, 8, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2640), "Distrito 8" },
                    { 98, true, 4, 1, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2641), "Distrito 1" },
                    { 99, true, 4, 2, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2641), "Distrito 2" },
                    { 100, true, 4, 3, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2642), "Distrito 3" },
                    { 101, true, 4, 4, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2643), "Distrito 4" },
                    { 102, true, 4, 5, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2644), "Distrito 5" },
                    { 103, true, 4, 6, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2645), "Distrito 6" },
                    { 104, true, 4, 7, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2646), "Distrito 7" },
                    { 105, true, 1, 1, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2647), "Distrito 1" },
                    { 106, true, 1, 2, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2648), "Distrito 2" },
                    { 107, true, 1, 3, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2649), "Distrito 3" },
                    { 108, true, 1, 4, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2650), "Distrito 4" },
                    { 109, true, 1, 5, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2651), "Distrito 5" },
                    { 110, true, 1, 6, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2652), "Distrito 6" },
                    { 111, true, 1, 7, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2652), "Distrito 7" },
                    { 112, true, 1, 8, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2653), "Distrito 8" },
                    { 113, true, 1, 9, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2654), "Distrito 9" },
                    { 114, true, 1, 10, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2655), "Distrito 10" },
                    { 115, true, 1, 11, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2656), "Distrito 11" },
                    { 116, true, 1, 12, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2657), "Distrito 12" },
                    { 117, true, 1, 13, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2658), "Distrito 13" },
                    { 118, true, 1, 14, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2659), "Distrito 14" },
                    { 119, true, 1, 15, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2660), "Distrito 15" },
                    { 120, true, 1, 16, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2661), "Distrito 16" },
                    { 121, true, 1, 17, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2668), "Distrito 17" },
                    { 122, true, 1, 18, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2669), "Distrito 18" },
                    { 123, true, 1, 19, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2670), "Distrito 19" },
                    { 124, true, 1, 20, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2671), "Distrito 20" },
                    { 125, true, 5, 1, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2671), "Distrito 1" },
                    { 126, true, 5, 2, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2672), "Distrito 2" },
                    { 127, true, 5, 3, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2673), "Distrito 3" },
                    { 128, true, 5, 4, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2674), "Distrito 4" },
                    { 129, true, 5, 5, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2675), "Distrito 5" },
                    { 130, true, 5, 6, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2677), "Distrito 6" },
                    { 131, true, 5, 7, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2678), "Distrito 7" },
                    { 132, true, 5, 8, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2679), "Distrito 8" },
                    { 133, true, 5, 9, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2679), "Distrito 9" },
                    { 134, true, 5, 10, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2680), "Distrito 10" },
                    { 135, true, 5, 11, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2681), "Distrito 11" },
                    { 136, true, 5, 12, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2682), "Distrito 12" },
                    { 137, true, 5, 13, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2683), "Distrito 13" },
                    { 138, true, 5, 14, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2684), "Distrito 14" },
                    { 139, true, 5, 15, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2685), "Distrito 15" },
                    { 140, true, 5, 16, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2686), "Distrito 16" },
                    { 141, true, 5, 17, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2687), "Distrito 17" },
                    { 142, true, 5, 18, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2688), "Distrito 18" },
                    { 143, true, 5, 19, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2689), "Distrito 19" },
                    { 144, true, 5, 20, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2690), "Distrito 20" },
                    { 145, true, 5, 21, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2690), "Distrito 21" },
                    { 146, true, 5, 22, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2691), "Distrito 22" },
                    { 147, true, 5, 23, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2692), "Distrito 23" },
                    { 148, true, 5, 24, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2693), "Distrito 24" },
                    { 149, true, 5, 25, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2694), "Distrito 25" },
                    { 150, true, 5, 26, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2695), "Distrito 26" },
                    { 151, true, 5, 27, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2696), "Distrito 27" },
                    { 152, true, 5, 28, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2697), "Distrito 28" },
                    { 153, true, 5, 29, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2698), "Distrito 29" },
                    { 154, true, 5, 30, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2699), "Distrito 30" },
                    { 155, true, 5, 31, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2700), "Distrito 31" },
                    { 156, true, 5, 32, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2701), "Distrito 32" },
                    { 157, true, 5, 33, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2701), "Distrito 33" },
                    { 158, true, 5, 34, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2702), "Distrito 34" },
                    { 159, true, 5, 35, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2703), "Distrito 35" },
                    { 160, true, 5, 36, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2704), "Distrito 36" },
                    { 161, true, 5, 37, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2705), "Distrito 37" },
                    { 162, true, 5, 38, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2706), "Distrito 38" },
                    { 163, true, 5, 39, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2707), "Distrito 39" },
                    { 164, true, 5, 40, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2708), "Distrito 40" },
                    { 165, true, 5, 1, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2709), "Distrito 1" },
                    { 166, true, 5, 2, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2710), "Distrito 2" },
                    { 167, true, 5, 3, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2711), "Distrito 3" },
                    { 168, true, 5, 4, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2712), "Distrito 4" },
                    { 169, true, 5, 5, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2713), "Distrito 5" },
                    { 170, true, 5, 6, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2713), "Distrito 6" },
                    { 171, true, 5, 7, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2714), "Distrito 7" },
                    { 172, true, 5, 8, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2715), "Distrito 8" },
                    { 173, true, 5, 9, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2716), "Distrito 9" },
                    { 174, true, 5, 10, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2717), "Distrito 10" },
                    { 175, true, 5, 11, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2718), "Distrito 11" },
                    { 176, true, 4, 1, 17, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2719), "Distrito 1" },
                    { 177, true, 4, 2, 17, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2720), "Distrito 2" },
                    { 178, true, 4, 3, 17, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2721), "Distrito 3" },
                    { 179, true, 4, 4, 17, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2722), "Distrito 4" },
                    { 180, true, 4, 5, 17, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2723), "Distrito 5" },
                    { 181, true, 1, 1, 18, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2724), "Distrito 1" },
                    { 182, true, 1, 2, 18, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2725), "Distrito 2" },
                    { 183, true, 1, 3, 18, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2725), "Distrito 3" },
                    { 184, true, 2, 1, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2726), "Distrito 1" },
                    { 185, true, 2, 2, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2727), "Distrito 2" },
                    { 186, true, 2, 3, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2728), "Distrito 3" },
                    { 187, true, 2, 4, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2729), "Distrito 4" },
                    { 188, true, 2, 5, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2730), "Distrito 5" },
                    { 189, true, 2, 6, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2731), "Distrito 6" },
                    { 190, true, 2, 7, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2732), "Distrito 7" },
                    { 191, true, 2, 8, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2733), "Distrito 8" },
                    { 192, true, 2, 9, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2734), "Distrito 9" },
                    { 193, true, 2, 10, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2735), "Distrito 10" },
                    { 194, true, 2, 11, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2736), "Distrito 11" },
                    { 195, true, 2, 12, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2736), "Distrito 12" },
                    { 196, true, 2, 13, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2737), "Distrito 13" },
                    { 197, true, 2, 14, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2738), "Distrito 14" },
                    { 198, true, 3, 1, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2739), "Distrito 1" },
                    { 199, true, 3, 2, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2740), "Distrito 2" },
                    { 200, true, 3, 3, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2741), "Distrito 3" },
                    { 201, true, 3, 4, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2742), "Distrito 4" },
                    { 202, true, 3, 5, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2743), "Distrito 5" },
                    { 203, true, 3, 6, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2744), "Distrito 6" },
                    { 204, true, 3, 7, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2745), "Distrito 7" },
                    { 205, true, 3, 8, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2746), "Distrito 8" },
                    { 206, true, 3, 9, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2752), "Distrito 9" },
                    { 207, true, 3, 10, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2753), "Distrito 10" },
                    { 208, true, 4, 1, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2754), "Distrito 1" },
                    { 209, true, 4, 2, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2755), "Distrito 2" },
                    { 210, true, 4, 3, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2756), "Distrito 3" },
                    { 211, true, 4, 4, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2757), "Distrito 4" },
                    { 212, true, 4, 5, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2758), "Distrito 5" },
                    { 213, true, 4, 6, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2758), "Distrito 6" },
                    { 214, true, 4, 7, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2759), "Distrito 7" },
                    { 215, true, 4, 8, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2760), "Distrito 8" },
                    { 216, true, 4, 9, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2761), "Distrito 9" },
                    { 217, true, 4, 10, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2762), "Distrito 10" },
                    { 218, true, 4, 11, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2763), "Distrito 11" },
                    { 219, true, 4, 12, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2764), "Distrito 12" },
                    { 220, true, 4, 13, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2765), "Distrito 13" },
                    { 221, true, 4, 14, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2766), "Distrito 14" },
                    { 222, true, 4, 15, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2767), "Distrito 15" },
                    { 223, true, 4, 16, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2768), "Distrito 16" },
                    { 224, true, 5, 1, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2769), "Distrito 1" },
                    { 225, true, 5, 2, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2770), "Distrito 2" },
                    { 226, true, 5, 3, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2770), "Distrito 3" },
                    { 227, true, 5, 4, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2771), "Distrito 4" },
                    { 228, true, 5, 5, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2772), "Distrito 5" },
                    { 229, true, 5, 6, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2773), "Distrito 6" },
                    { 230, true, 3, 1, 23, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2774), "Distrito 1" },
                    { 231, true, 3, 2, 23, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2775), "Distrito 2" },
                    { 232, true, 3, 3, 23, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2776), "Distrito 3" },
                    { 233, true, 3, 4, 23, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2777), "Distrito 4" },
                    { 234, true, 2, 1, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2778), "Distrito 1" },
                    { 235, true, 2, 2, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2779), "Distrito 2" },
                    { 236, true, 2, 3, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2780), "Distrito 3" },
                    { 237, true, 2, 4, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2781), "Distrito 4" },
                    { 238, true, 2, 5, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2782), "Distrito 5" },
                    { 239, true, 2, 6, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2782), "Distrito 6" },
                    { 240, true, 2, 7, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2783), "Distrito 7" },
                    { 241, true, 1, 1, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2784), "Distrito 1" },
                    { 242, true, 1, 2, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2785), "Distrito 2" },
                    { 243, true, 1, 3, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2786), "Distrito 3" },
                    { 244, true, 1, 4, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2787), "Distrito 4" },
                    { 245, true, 1, 5, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2788), "Distrito 5" },
                    { 246, true, 1, 6, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2789), "Distrito 6" },
                    { 247, true, 1, 7, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2790), "Distrito 7" },
                    { 248, true, 1, 1, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2791), "Distrito 1" },
                    { 249, true, 1, 2, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2792), "Distrito 2" },
                    { 250, true, 1, 3, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2792), "Distrito 3" },
                    { 251, true, 1, 4, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2793), "Distrito 4" },
                    { 252, true, 1, 5, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2794), "Distrito 5" },
                    { 253, true, 1, 6, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2795), "Distrito 6" },
                    { 254, true, 1, 7, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2796), "Distrito 7" },
                    { 255, true, 3, 1, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2797), "Distrito 1" },
                    { 256, true, 3, 2, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2798), "Distrito 2" },
                    { 257, true, 3, 3, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2799), "Distrito 3" },
                    { 258, true, 3, 4, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2801), "Distrito 4" },
                    { 259, true, 3, 5, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2802), "Distrito 5" },
                    { 260, true, 3, 6, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2803), "Distrito 6" },
                    { 261, true, 2, 1, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2804), "Distrito 1" },
                    { 262, true, 2, 2, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2811), "Distrito 2" },
                    { 263, true, 2, 3, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2812), "Distrito 3" },
                    { 264, true, 2, 4, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2813), "Distrito 4" },
                    { 265, true, 2, 5, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2814), "Distrito 5" },
                    { 266, true, 2, 6, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2815), "Distrito 6" },
                    { 267, true, 2, 7, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2816), "Distrito 7" },
                    { 268, true, 2, 8, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2817), "Distrito 8" },
                    { 269, true, 4, 1, 29, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2818), "Distrito 1" },
                    { 270, true, 4, 2, 29, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2819), "Distrito 2" },
                    { 271, true, 4, 3, 29, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2820), "Distrito 3" },
                    { 272, true, 3, 1, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2821), "Distrito 1" },
                    { 273, true, 3, 2, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2822), "Distrito 2" },
                    { 274, true, 3, 3, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2822), "Distrito 3" },
                    { 275, true, 3, 4, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2823), "Distrito 4" },
                    { 276, true, 3, 5, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2824), "Distrito 5" },
                    { 277, true, 3, 6, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2825), "Distrito 6" },
                    { 278, true, 3, 7, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2826), "Distrito 7" },
                    { 279, true, 3, 8, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2827), "Distrito 8" },
                    { 280, true, 3, 9, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2828), "Distrito 9" },
                    { 281, true, 3, 10, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2829), "Distrito 10" },
                    { 282, true, 3, 11, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2830), "Distrito 11" },
                    { 283, true, 3, 12, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2831), "Distrito 12" },
                    { 284, true, 3, 13, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2832), "Distrito 13" },
                    { 285, true, 3, 14, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2833), "Distrito 14" },
                    { 286, true, 3, 15, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2834), "Distrito 15" },
                    { 287, true, 3, 16, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2834), "Distrito 16" },
                    { 288, true, 3, 17, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2835), "Distrito 17" },
                    { 289, true, 3, 18, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2836), "Distrito 18" },
                    { 290, true, 3, 19, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2837), "Distrito 19" },
                    { 291, true, 3, 1, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2838), "Distrito 1" },
                    { 292, true, 3, 2, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2839), "Distrito 2" },
                    { 293, true, 3, 3, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2840), "Distrito 3" },
                    { 294, true, 3, 4, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2841), "Distrito 4" },
                    { 295, true, 3, 5, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2842), "Distrito 5" },
                    { 296, true, 3, 6, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2843), "Distrito 6" },
                    { 297, true, 2, 1, 32, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2844), "Distrito 1" },
                    { 298, true, 2, 2, 32, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2844), "Distrito 2" },
                    { 299, true, 2, 3, 32, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2845), "Distrito 3" },
                    { 300, true, 2, 4, 32, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2846), "Distrito 4" }
                });

            migrationBuilder.InsertData(
                table: "estado_circunscripcion",
                columns: new[] { "id", "activo", "circunscripcion_id", "entidad_id", "fecha_creacion" },
                values: new object[,]
                {
                    { 1, true, 2, 1, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2974) },
                    { 2, true, 1, 2, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2984) },
                    { 3, true, 1, 3, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2985) },
                    { 4, true, 3, 4, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2985) },
                    { 5, true, 2, 5, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2986) },
                    { 6, true, 5, 6, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2987) },
                    { 7, true, 3, 7, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2988) },
                    { 8, true, 1, 8, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2989) },
                    { 9, true, 4, 9, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2989) },
                    { 10, true, 1, 10, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2990) },
                    { 11, true, 2, 11, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2991) },
                    { 12, true, 4, 12, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2992) },
                    { 13, true, 4, 13, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2993) },
                    { 14, true, 1, 14, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2993) },
                    { 15, true, 5, 15, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2994) },
                    { 16, true, 5, 16, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2995) },
                    { 17, true, 4, 17, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2996) },
                    { 18, true, 1, 18, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2997) },
                    { 19, true, 2, 19, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2998) },
                    { 20, true, 3, 20, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2998) },
                    { 21, true, 4, 21, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(2999) },
                    { 22, true, 5, 22, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3000) },
                    { 23, true, 3, 23, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3001) },
                    { 24, true, 2, 24, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3001) },
                    { 25, true, 1, 25, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3002) },
                    { 26, true, 1, 26, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3003) },
                    { 27, true, 3, 27, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3004) },
                    { 28, true, 2, 28, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3004) },
                    { 29, true, 4, 29, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3005) },
                    { 30, true, 3, 30, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3006) },
                    { 31, true, 3, 31, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3006) },
                    { 32, true, 2, 32, new DateTime(2023, 10, 5, 18, 29, 6, 151, DateTimeKind.Utc).AddTicks(3007) }
                });

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_circunscripcion_id",
                table: "candidatos_chc",
                column: "circunscripcion_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_distrito_id",
                table: "candidatos_chc",
                column: "distrito_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_estado_id",
                table: "candidatos_chc",
                column: "estado_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidatos_chc_representante_id",
                table: "candidatos_chc",
                column: "representante_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidato_persona_candidato_id",
                table: "candidato_persona",
                column: "candidato_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidato_persona_persona_id",
                table: "candidato_persona",
                column: "persona_id");

            migrationBuilder.CreateIndex(
                name: "ix_detalle_requisito_diputaciones_entidad_id",
                table: "detalle_requisito_diputaciones",
                column: "entidad_id");

            migrationBuilder.CreateIndex(
                name: "ix_distritos_federales_circunscripcion_id",
                table: "distritos_federales",
                column: "circunscripcion_id");

            migrationBuilder.CreateIndex(
                name: "ix_distritos_federales_entidad_id",
                table: "distritos_federales",
                column: "entidad_id");

            migrationBuilder.CreateIndex(
                name: "ix_estado_circunscripcion_circunscripcion_id",
                table: "estado_circunscripcion",
                column: "circunscripcion_id");

            migrationBuilder.CreateIndex(
                name: "ix_estado_circunscripcion_entidad_id",
                table: "estado_circunscripcion",
                column: "entidad_id");

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_catalogo_circunscripcion_circunscripcion_id",
                table: "candidatos_chc",
                column: "circunscripcion_id",
                principalTable: "catalogo_circunscripcion",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_catalogo_representante_representante_id",
                table: "candidatos_chc",
                column: "representante_id",
                principalTable: "catalogo_representante",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_distritos_federales_distrito_id",
                table: "candidatos_chc",
                column: "distrito_id",
                principalTable: "distritos_federales",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_entidad_federativa_estado_id",
                table: "candidatos_chc",
                column: "estado_id",
                principalTable: "entidad_federativa",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_perfil_perfil_id",
                table: "candidatos_chc",
                column: "perfil_id",
                principalTable: "perfil",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_catalogo_circunscripcion_circunscripcion_id",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_catalogo_representante_representante_id",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_distritos_federales_distrito_id",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_entidad_federativa_estado_id",
                table: "candidatos_chc");

            migrationBuilder.DropForeignKey(
                name: "fk_candidatos_chc_perfil_perfil_id",
                table: "candidatos_chc");

            migrationBuilder.DropTable(
                name: "candidato_persona");

            migrationBuilder.DropTable(
                name: "catalogo_representante");

            migrationBuilder.DropTable(
                name: "detalle_requisito_diputaciones");

            migrationBuilder.DropTable(
                name: "distritos_federales");

            migrationBuilder.DropTable(
                name: "estado_circunscripcion");

            migrationBuilder.DropTable(
                name: "catalogo_circunscripcion");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_circunscripcion_id",
                table: "candidatos_chc");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_distrito_id",
                table: "candidatos_chc");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_estado_id",
                table: "candidatos_chc");

            migrationBuilder.DropIndex(
                name: "ix_candidatos_chc_representante_id",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "en_circulo",
                table: "perfil_sigue_perfil");

            migrationBuilder.DropColumn(
                name: "afromexicanas",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "circunscripcion_id",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "con_discapacidad",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "dato_de_prueba",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "distrito_id",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "diversidad_sexual",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "en_pobreza",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "es_suplente",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "estado_id",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "identificacion_indigena",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "mexicanos_migrantes",
                table: "candidatos_chc");

            migrationBuilder.DropColumn(
                name: "representante_id",
                table: "candidatos_chc");

            migrationBuilder.AlterColumn<int>(
                name: "perfil_id",
                table: "candidatos_chc",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 817, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 817, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9466), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9472), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9474), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9476), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9479), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9481), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9483), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9485), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9488), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9491), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9492), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9494), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9495), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9497), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9498), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9501), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9502), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9504), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9505), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9506), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9509), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9511), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9512), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9514), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9515), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9517), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9518), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9521), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9522), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9524), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9525), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9526), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9527), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9531), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9533), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9534), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9535), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9536), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9538), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9539), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9542), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9543), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9544), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9545), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9548), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9549), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9552), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9553), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9554), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9557), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9558), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9589), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9592), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9593), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9594), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9596), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9598), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9602), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9604), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9606), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9607), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9608), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9611), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9613), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9614), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9615), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9616), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9618), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9619), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9623), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9627), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9629), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9633), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9635), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9636), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9637), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9641), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9644), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9645), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9647), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9649), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9651), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9652), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9654), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9655), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9656), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8342), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8353), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8355), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8356), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8359), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8361), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8362), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8363), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8364), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8366), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8367), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8369), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8370), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8371), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8372), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8373), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8374), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8375), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8376), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8377), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8378), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8379), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8380), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8423), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8619), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(7122), new DateTime(2023, 10, 3, 22, 53, 6, 816, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.AddForeignKey(
                name: "fk_candidatos_chc_perfil_perfil_id",
                table: "candidatos_chc",
                column: "perfil_id",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
