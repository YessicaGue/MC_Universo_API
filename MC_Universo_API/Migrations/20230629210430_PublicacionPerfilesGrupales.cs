using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class PublicacionPerfilesGrupales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(788), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(795), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(798), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(802), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(807), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(809), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(811), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(813), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(817), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(819), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(846), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(848), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(851), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(853), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(859), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(866), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(868), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(873), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(875), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(877), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(879), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(882), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(884), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(886), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(888), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(971), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1397), new DateTime(2023, 6, 29, 21, 4, 29, 301, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 29, 21, 4, 29, 300, DateTimeKind.Utc).AddTicks(8238), new DateTime(2023, 6, 29, 21, 4, 29, 300, DateTimeKind.Utc).AddTicks(8241) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7404), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7410), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7411), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7412), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7413), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7415), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7416), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7417), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7420), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7421), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7422), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7423), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7424), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7425), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7426), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7427), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7430), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7431), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7432), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7434), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7435), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7436), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7437), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7438), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7439), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7440), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7441), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7442), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7443), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7704), new DateTime(2023, 6, 23, 11, 50, 27, 640, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 29, 0, 485, DateTimeKind.Utc).AddTicks(4226), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
