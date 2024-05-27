using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeJulio20230824 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropForeignKey(
                name: "fk_examenes_candidatos_perfil_examen_chc_id",
                table: "examenes_candidatos");

            migrationBuilder.CreateTable(
                name: "catalogo_etapa_registro_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    nombre_url_route = table.Column<string>(type: "text", nullable: true),
                    indice_orden = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_etapa_registro_chc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "candidato_etapa_registro_chc",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    candidato_id = table.Column<int>(type: "integer", nullable: false),
                    registro_id = table.Column<int>(type: "integer", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_candidato_etapa_registro_chc", x => x.id);
                    table.ForeignKey(
                        name: "fk_candidato_etapa_registro_chc_candidatos_chc_candidato_id",
                        column: x => x.candidato_id,
                        principalTable: "candidatos_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_candidato_etapa_registro_chc_catalogo_etapa_registro_chc_re",
                        column: x => x.registro_id,
                        principalTable: "catalogo_etapa_registro_chc",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7168), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7170), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7171), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7172), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7174), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7176), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7177), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7179), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7180), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7181), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7182), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7183), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7184), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7185), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7187), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7188), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7189), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7190), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7192), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7193), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7194), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7195), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7196), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7197), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7198), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7199), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7202), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7203), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7204), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7205), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7207), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7208), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7209), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7210), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7211), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7212), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7213), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7214), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7215), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7217), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7218), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7219), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7220), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7221), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7222), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7223), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7224), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7249), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7251), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7252), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7253), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7254), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7255), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7256), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7257), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7259), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7260), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7261), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7262), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7263), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7264), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7265), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7267), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7268), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7269), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7270), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7272), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7273), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7274), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7275), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7276), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7277), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7278), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7279), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7280), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7281), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7283), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7284), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7285), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7286), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7287), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7288), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7289), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7290), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7291), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7292), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7294), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7295), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7296), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7297), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7298), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7299), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7300), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7301), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7302), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7304), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7305), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7306), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7307), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7308), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7309), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7310), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7311), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7312), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7314), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6012), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6013), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6014), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6015), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6018), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6019), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6020), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6021), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6023), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6025), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6027), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6028), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6029), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6031), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6032), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6033), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6034), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6035), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6036), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6037), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6038), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6039), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6040), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6041), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6043), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6044), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6045), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.InsertData(
                table: "examenes_chc",
                columns: new[] { "id", "activo", "fecha_alta", "nombre_examen" },
                values: new object[] { 3, true, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7470), "Evaluación valores" });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6294), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(4690), new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.InsertData(
                table: "preguntas_examen_chc",
                columns: new[] { "id", "activo", "examen_chc_id", "fecha_alta", "pregunta", "tipo_pregunta_id" },
                values: new object[,]
                {
                    { 6, true, 3, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7511), "¿Qué está prohibido por la ley 3 de 3 y hace que una persona no pueda participar en el camino del héroe y la heroína ciudadana?", 1 },
                    { 7, true, 3, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7512), "¿En cuáles documentos se encuentran los valores, propuestas y principios de Movimiento Ciudadano que todas las personas participantes del camino del héroe y la heroína ciudadana deben seguir?", 1 },
                    { 8, true, 3, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7513), "¿El camino del héroe y la heroína ciudadana se  encuentra  vinculado  con  las  convocatorias  de  la  Comisión  Nacional  de  Convenciones  y  Procesos  Internos  de  Movimiento  Ciudadano?", 1 },
                    { 9, true, 3, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7514), "Selecciona la respuesta que incluye algunos de los principios que Movimiento Ciudadano respalda:", 1 },
                    { 10, true, 3, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7516), "¿Cuáles son los 5 ejes de la Carta de Identidad donde se encuentran los 22 compromisos solemnes que las personas que colaboran con Movimiento Ciudadano se comprometen a cumplir?", 1 }
                });

            migrationBuilder.InsertData(
                table: "respuesta_examen_chc",
                columns: new[] { "id", "activo", "es_correcta", "fecha_alta", "pregunta_examen_chc_id", "respuesta" },
                values: new object[,]
                {
                    { 16, true, true, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7576), 6, "Haber sido condenado o sentenciado por una agresión de género, delitos sexuales, o por ser deudor alimentario." },
                    { 17, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7577), 6, "No presentar tu declaración patrimonial en tiempo y forma." },
                    { 18, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7579), 6, "No lo sé." },
                    { 19, true, true, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7580), 7, "Carta Progresista, Carta Compromiso,Carta de Identidad, Declaración de Principios y Programa de Acción de Movimiento Ciudadano." },
                    { 20, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7581), 7, "Plan de Acción, Carta Compromiso, Estatutos, Carta Progresista y Libro de Valores de Movimiento Ciudadano." },
                    { 21, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7583), 7, "No lo sé." },
                    { 22, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7584), 8, "Si." },
                    { 23, true, true, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7586), 8, "No." },
                    { 24, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7587), 8, "No lo sé." },
                    { 25, true, true, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7589), 9, "Democracia social, igualdad sustantiva entre hombres y mujeres, economía social de mercado, inclusión social y fortalecimiento del poder ciudadano." },
                    { 26, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7590), 9, "Desarrollo económico basado en el uso de combustibles fósiles, asistencialismo social, centralismo político." },
                    { 27, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7591), 9, "No lo sé." },
                    { 28, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7592), 10, "Desarrollo económico, Pluralismo, Salud y bienestar, Educación y Seguridad." },
                    { 29, true, true, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7594), 10, "Estado, soberanía popular y democracia; Derechos humanos; Equidad y desarrollo económico; Rendición de cuentas, transparencia y combate a la corrupción; Federalismo y Municipalismo." },
                    { 30, true, false, new DateTime(2023, 8, 24, 16, 31, 12, 308, DateTimeKind.Utc).AddTicks(7595), 10, "No lo sé." }
                });

            migrationBuilder.CreateIndex(
                name: "ix_candidato_etapa_registro_chc_candidato_id",
                table: "candidato_etapa_registro_chc",
                column: "candidato_id");

            migrationBuilder.CreateIndex(
                name: "ix_candidato_etapa_registro_chc_registro_id",
                table: "candidato_etapa_registro_chc",
                column: "registro_id");

            migrationBuilder.AddForeignKey(
                name: "fk_examenes_candidatos_examenes_chc_examen_chc_id",
                table: "examenes_candidatos",
                column: "examen_chc_id",
                principalTable: "examenes_chc",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_examenes_candidatos_examenes_chc_examen_chc_id",
                table: "examenes_candidatos");

            migrationBuilder.DropTable(
                name: "candidato_etapa_registro_chc");

            migrationBuilder.DropTable(
                name: "catalogo_etapa_registro_chc");

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8768), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8771), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8773), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8775), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8776), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8778), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8779), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8781), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8783), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8784), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8786), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8787), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8788), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8790), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8792), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8794), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8795), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8796), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8798), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8799), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8800), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8802), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8803), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8804), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8806), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8807), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8808), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8810), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8811), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8812), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8814), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8816), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8818), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8819), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8822), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8823), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8824), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8825), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8827), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8828), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8829), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8831), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8832), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8833), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8835), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8836), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8837), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8838), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8840), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8841), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8842), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8843), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8845), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8846), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8847), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8849), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8850), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8851), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8852), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8854), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8855), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8856), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8919), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8922), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8923), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8925), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8926), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8927), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8928), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8931), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8932), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8934), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8935), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8937), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8938), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8939), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8940), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8942), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8943), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8944), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8946), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8947), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8949), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8950), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8951), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8953), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8954), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8955), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8957), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8958), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8959), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8961), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8962), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8963), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8964), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8966), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8967), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8969), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8970), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8971), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8972), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8974), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8975), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6847), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6856), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6857), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6858), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6861), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6862), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6863), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6864), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6867), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6868), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6884), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6885), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6886), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6888), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6889), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6890), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6892), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6894), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6895), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6896), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6898), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6899), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6902), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6903), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6904), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6905), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6906), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6908), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6909), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6910), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6985), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7328), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(4541), new DateTime(2023, 8, 18, 17, 22, 52, 486, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.AddForeignKey(
                name: "fk_examenes_candidatos_perfil_examen_chc_id",
                table: "examenes_candidatos",
                column: "examen_chc_id",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
