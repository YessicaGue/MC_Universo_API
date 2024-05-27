using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasPublicacionesArchivosSeguidoresCorregidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8209), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8215), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8216), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8218), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8219), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8221), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8222), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8223), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8224), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8225), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8226), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8227), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8228), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8229), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8230), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8231), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8233), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8234), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8235), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8236), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8237), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8238), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8239), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8240), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8241), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8242), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8243), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8244), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8245), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8246), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8247), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8277), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8477), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(6955), new DateTime(2023, 6, 1, 8, 52, 32, 350, DateTimeKind.Utc).AddTicks(6959) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6076), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6077), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6078), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6080), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6082), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6083), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6084), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6087), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6088), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6092), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6094), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6096), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6097), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6098), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6099), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6100), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6101), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6102), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6103), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6104), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6104), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6105), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6106), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6107), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6108), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6109), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6149), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(4844), new DateTime(2023, 5, 30, 22, 35, 56, 775, DateTimeKind.Utc).AddTicks(4847) });
        }
    }
}
