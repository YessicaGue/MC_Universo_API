using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaEscuchaColumnasEliminadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha");

            migrationBuilder.DropIndex(
                name: "ix_escucha_entidad_federativa_id",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "apellido_materno",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "apellido_paterno",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "entidad_federativa_id",
                table: "escucha");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "escucha");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(715), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(723), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(724), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(727), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(729), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(730), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(731), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(735), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(737), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(739), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(740), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(741), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(742), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(743), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(746), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(753), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(754), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(755), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(756), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(760), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(763), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(766), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(767), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(768), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(834), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1172), new DateTime(2023, 6, 13, 0, 22, 43, 712, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 22, 43, 711, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 6, 13, 0, 22, 43, 711, DateTimeKind.Utc).AddTicks(8619) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellido_materno",
                table: "escucha",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "apellido_paterno",
                table: "escucha",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "escucha",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "entidad_federativa_id",
                table: "escucha",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "escucha",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6771), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6778), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6779), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6782), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6784), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6785), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6787), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6788), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6790), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6791), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6794), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6795), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6796), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6799), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6801), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6802), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6844), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6846), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6848), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6849), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6850), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6851), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6853), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6854), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6856), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6858), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6917), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7152), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(5161), new DateTime(2023, 6, 12, 5, 55, 56, 902, DateTimeKind.Utc).AddTicks(5172) });

            migrationBuilder.CreateIndex(
                name: "ix_escucha_entidad_federativa_id",
                table: "escucha",
                column: "entidad_federativa_id");

            migrationBuilder.AddForeignKey(
                name: "fk_escucha_entidad_federativa_entidad_federativa_id",
                table: "escucha",
                column: "entidad_federativa_id",
                principalTable: "entidad_federativa",
                principalColumn: "id");
        }
    }
}
