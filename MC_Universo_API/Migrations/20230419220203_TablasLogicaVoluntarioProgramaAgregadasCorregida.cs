using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablasLogicaVoluntarioProgramaAgregadasCorregida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2737), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2738), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2739), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2741), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2742), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2743), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2745), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2747), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2748), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2749), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2750), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2751), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2752), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2753), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2755), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2756), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2757), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2758), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2759), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2760), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2761), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2762), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2763), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2764), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2765), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2766), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2767), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2768), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2769), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2801), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3022), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 4, 19, 22, 2, 3, 41, DateTimeKind.Utc).AddTicks(1145) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
