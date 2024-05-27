using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaCatalogoRedesSocialesAgregada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalogo_redes_sociales",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_catalogo_redes_sociales", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.InsertData(
                table: "catalogo_redes_sociales",
                columns: new[] { "id", "activo", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8312), "Facebook" },
                    { 2, true, new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8316), "Instagram" },
                    { 3, true, new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8316), "Twitter" },
                    { 4, true, new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8317), "TikTok" },
                    { 5, true, new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8318), "WhatsApp" },
                    { 6, true, new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(8319), "LinkedIn" }
                });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7548), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7554), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7556), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7557), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7558), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7562), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7563), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7564), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7565), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7566), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7568), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7569), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7571), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7572), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7575), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7576), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7577), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7579), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7580), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7584), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7629), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7837), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(6284), new DateTime(2023, 6, 12, 1, 46, 13, 248, DateTimeKind.Utc).AddTicks(6288) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catalogo_redes_sociales");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2848), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2856), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2858), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2859), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2860), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2863), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2864), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2866), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2867), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2869), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2870), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2872), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2873), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2874), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2877), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2878), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2880), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2881), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2882), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2884), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2885), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2887), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2888), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2889), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2890), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2891), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2893), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2894), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2895), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2896), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2898), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3014), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3262), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(1146), new DateTime(2023, 6, 10, 1, 24, 0, 651, DateTimeKind.Utc).AddTicks(1150) });
        }
    }
}
