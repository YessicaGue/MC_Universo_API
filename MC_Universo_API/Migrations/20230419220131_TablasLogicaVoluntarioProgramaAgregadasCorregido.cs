using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasLogicaVoluntarioProgramaAgregadasCorregido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(193), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(197), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(198), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(199), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(200), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(202), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(203), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(204), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(205), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(206), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(207), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(208), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(210), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(211), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(212), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(213), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(214), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(216), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(217), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(218), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(219), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(221), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(222), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(223), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(224), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(225), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(226), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(227), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(228), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(229), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(230), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(256), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(456), new DateTime(2023, 4, 19, 22, 1, 30, 830, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 1, 30, 829, DateTimeKind.Utc).AddTicks(8901), new DateTime(2023, 4, 19, 22, 1, 30, 829, DateTimeKind.Utc).AddTicks(8905) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(885), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(891), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(893), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(894), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(895), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(897), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(899), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(900), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(901), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(904), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(905), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(906), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(907), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(909), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(910), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(911), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(912), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(913), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(915), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(916), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(918), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(919), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(943), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(944), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(945), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(946), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(947), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(948), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(983), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1189), new DateTime(2023, 4, 19, 21, 35, 6, 35, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 21, 35, 6, 34, DateTimeKind.Utc).AddTicks(9672), new DateTime(2023, 4, 19, 21, 35, 6, 34, DateTimeKind.Utc).AddTicks(9675) });
        }
    }
}
