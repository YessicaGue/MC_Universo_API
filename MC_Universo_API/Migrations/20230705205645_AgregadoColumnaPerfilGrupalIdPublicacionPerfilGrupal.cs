using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoColumnaPerfilGrupalIdPublicacionPerfilGrupal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "perfil_grupal_id",
                table: "publicacion_perfil_grupal",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1513), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1521), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1522), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1523), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1525), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1526), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1527), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1529), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1532), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1533), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1534), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1535), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1536), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1537), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1539), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1543), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1544), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1548), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1551), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1552), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "frase" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2450), "La unión hace cambios" });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1791), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(265), new DateTime(2023, 7, 5, 20, 56, 45, 142, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.CreateIndex(
                name: "ix_publicacion_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal",
                column: "perfil_grupal_id");

            migrationBuilder.AddForeignKey(
                name: "fk_publicacion_perfil_grupal_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal",
                column: "perfil_grupal_id",
                principalTable: "perfil_grupal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_publicacion_perfil_grupal_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.DropIndex(
                name: "ix_publicacion_perfil_grupal_perfil_grupal_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.DropColumn(
                name: "perfil_grupal_id",
                table: "publicacion_perfil_grupal");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4807), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4811), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4812), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4813), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4814), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4816), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4817), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4818), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4819), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4822), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4823), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4824), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4825), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4826), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4827), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4828), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4829), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4830), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4832), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4832), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4833), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4835), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4836), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4837), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4837), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4838), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4840), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4841), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4842), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4843), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4844), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4845), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "frase" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5663), "La uniòn hace cambios" });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4876), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5078), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 7, 5, 18, 55, 12, 246, DateTimeKind.Utc).AddTicks(3680) });
        }
    }
}
