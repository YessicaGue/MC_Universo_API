using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class PerfilUuidAgregado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "perfil",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1570), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1577), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1579), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1582), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1583), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1587), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1589), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1590), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1593), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1594), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1596), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1598), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1599), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1603), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1605), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1606), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1608), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1609), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1648), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(171), new DateTime(2023, 6, 22, 3, 15, 10, 88, DateTimeKind.Utc).AddTicks(176) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "guid",
                table: "perfil");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8133), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8142), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8143), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8145), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8146), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8148), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8149), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8151), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8152), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8153), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8153), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8155), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8156), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8157), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8158), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8159), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8160), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8161), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8162), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8163), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8164), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8165), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8166), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8168), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8169), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8170), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8171), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8172), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8436), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(6864), new DateTime(2023, 6, 13, 2, 19, 40, 460, DateTimeKind.Utc).AddTicks(6867) });
        }
    }
}
