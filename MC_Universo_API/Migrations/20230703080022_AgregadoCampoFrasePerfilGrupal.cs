using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoCampoFrasePerfilGrupal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "frase",
                table: "perfil_grupal",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2340), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2376), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2378), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2379), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2380), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2381), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2382), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2383), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2384), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2387), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2388), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2389), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2390), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2392), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2393), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2395), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2397), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2398), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2399), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2400), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2401), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2402), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2403), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2404), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2405), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2406), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2407), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2408), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2409), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2410), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2411), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2460), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2753), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(690), new DateTime(2023, 7, 3, 8, 0, 21, 697, DateTimeKind.Utc).AddTicks(694) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "frase",
                table: "perfil_grupal");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5401), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5407), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5408), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5409), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5410), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5412), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5413), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5414), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5415), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5417), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5418), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5419), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5420), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5425), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5426), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5427), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5428), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5430), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5431), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5432), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5433), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5434), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5435), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5436), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5437), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5438), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5439), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5440), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5441), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5442), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5443), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5444), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5477), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5696), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(4078), new DateTime(2023, 6, 30, 17, 50, 13, 421, DateTimeKind.Utc).AddTicks(4082) });
        }
    }
}
