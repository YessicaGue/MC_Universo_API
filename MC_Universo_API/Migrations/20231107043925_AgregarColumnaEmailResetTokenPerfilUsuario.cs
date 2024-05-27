using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarColumnaEmailResetTokenPerfilUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "email_reset_token",
                table: "perfil_usuario",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3989), "lmy75iyg" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3998), "m5dpcfsb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4001), "afexc2tg" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4004), "2hm37cqb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4007), "dwj1c3qu" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4010), "5zedujzp" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4012), "enye2sf8" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2820), "199fuoi1" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2845), "9ukqrjc9" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2848), "c5mz1l1g" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2851), "r858sryt" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2869), "qraj4byu" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4116), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4122), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4123), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2167), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2176), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2177), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2186), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2190), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2192), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2196), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2197), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2198), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2201), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2206), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2208), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2212), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2213), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2247), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2249), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2250), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2251), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2252), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2254), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2255), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2256), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2258), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2259), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2261), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2262), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2263), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2264), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2266), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2267), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2268), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2269), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2271), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2272), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2273), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2275), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2276), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2277), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2280), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2281), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2282), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2284), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2285), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2287), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2288), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2289), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2291), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2292), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2293), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2295), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2296), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2297), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2299), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2300), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2301), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2302), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2303), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2305), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2306), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2307), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2309), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2310), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2311), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2313), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2314), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2315), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2317), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2318), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2319), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2320), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2321), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2323), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2324), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2326), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2327), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2328), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2329), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2331), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2332), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2333), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2334), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2336), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2337), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2338), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2340), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2341), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2342), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2371), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2372), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2374), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2375), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2376), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2378), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2379), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2897), "lsu5qias" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2903), "m1euzera" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2906), "hfffbyku" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2909), "32i8u6s5" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2912), "gck2okm2" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4151), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4172), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4176), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4177), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4205), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4211), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4322), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4324), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4326), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4231), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4285), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4286), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4287), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(973), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(980), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(981), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(982), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(983), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(985), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(986), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(989), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(991), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(992), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(994), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(995), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(997), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(998), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1000), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1001), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1003), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1005), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1006), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1007), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1010), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1011), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1012), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1014), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1015), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1048), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1336), new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 7, 4, 39, 24, 405, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 7, 4, 39, 24, 404, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 11, 7, 4, 39, 24, 404, DateTimeKind.Utc).AddTicks(9755) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email_reset_token",
                table: "perfil_usuario");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(91), "t97kr1aq" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(103), "qzxinwb3" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(106), "7e7a3ueo" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(109), "vs8of2b8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(112), "r9c15gve" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(115), "niuetxez" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(118), "h168wl3z" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9080), "d4h7bv07" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9103), "9eh4dkq1" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9106), "7ms6kj9n" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9109), "rde8rxzb" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9120), "ysu9nshy" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(218), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(222), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(223), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8457), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8464), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8466), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8467), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8475), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8478), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8483), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8485), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8486), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8488), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8489), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8490), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8492), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8493), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8494), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8495), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8497), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8498), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8500), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8501), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8503), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8504), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8505), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8507), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8508), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8509), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8512), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8513), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8514), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8516), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8517), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8518), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8522), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8523), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8524), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8526), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8527), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8528), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8529), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8531), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8532), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8533), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8535), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8536), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8537), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8539), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8540), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8541), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8543), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8544), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8545), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8546), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8548), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8549), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8550), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8552), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8553), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8554), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8556), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8557), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8558), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8560), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8561), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8563), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8564), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8572), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8574), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8575), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8577), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8578), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8579), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8580), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8582), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8583), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8584), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8586), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8587), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8588), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8589), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8591), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8592), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8594), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8595), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8596), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8597), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8599), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8600), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8601), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8603), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8604), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8605), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8606), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8608), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8609), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8611), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8612), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8615), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8616), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8618), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8619), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8621), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8622), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8624), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8625), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8626), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8628), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8629), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8630), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8632), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8633), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8634), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8636), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8637), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9157), "uqzxv30y" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9172), "ri5p9pin" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9175), "k7noqkz7" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9179), "x4ramwy2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9182), "qx8v7ukw" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(258), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(289), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(293), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(294), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(325), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(329), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(394), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(398), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(401), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(402), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(403), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(404), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(405), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(406), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(361), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(365), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(366), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(367), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7273), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7277), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7278), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7279), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7280), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7282), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7283), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7285), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7286), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7294), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7295), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7305), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7306), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7312), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7313), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7314), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7315), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7316), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7317), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7318), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7319), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7320), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7321), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7322), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7323), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7324), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7325), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7326), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7327), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7328), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7329), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7330), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7372), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7615), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(6115), new DateTime(2023, 11, 2, 17, 34, 54, 192, DateTimeKind.Utc).AddTicks(6120) });
        }
    }
}
