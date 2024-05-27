using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoColumnaFraseYFoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "foto",
                table: "perfil_grupal",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1830), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1831), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1836), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1837), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1838), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1840), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1843), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1844), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1845), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1846), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1849), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1852), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1853), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1854), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1856), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1858), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1859), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1860), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1862), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1863), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1864), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1865), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1866), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1868), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1869), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1986), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2319), new DateTime(2023, 7, 4, 8, 41, 4, 854, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 4, 8, 41, 4, 853, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 7, 4, 8, 41, 4, 853, DateTimeKind.Utc).AddTicks(9816) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foto",
                table: "perfil_grupal");

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
    }
}
