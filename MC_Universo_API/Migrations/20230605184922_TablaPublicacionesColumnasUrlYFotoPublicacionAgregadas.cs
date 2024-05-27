using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaPublicacionesColumnasUrlYFotoPublicacionAgregadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagen_publicacion",
                table: "publicacion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "publicacion",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1685), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1692), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1693), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1694), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1696), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1698), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1699), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1700), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1701), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1703), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1704), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1710), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1711), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1713), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1713), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1714), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1716), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1718), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1719), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1721), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1722), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1723), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1724), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1725), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1757), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1967), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(251), new DateTime(2023, 6, 5, 18, 49, 22, 172, DateTimeKind.Utc).AddTicks(255) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagen_publicacion",
                table: "publicacion");

            migrationBuilder.DropColumn(
                name: "url",
                table: "publicacion");

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
    }
}
