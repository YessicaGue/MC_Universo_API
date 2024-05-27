using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ColumnaGuidAgregadaTablasPublicaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "publicacion_perfil_grupal",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "publicacion",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1109), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1118), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9522), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9531), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9533), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9534), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9537), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9538), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9546), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9549), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9552), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9553), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9554), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9557), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9558), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9561), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9563), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9565), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9567), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9571), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9576), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9577), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9579), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9582), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9583), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9584), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9586), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9587), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9588), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9591), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9592), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9594), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9595), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9596), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9597), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9599), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9603), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9604), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9606), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9608), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9609), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9612), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9613), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9615), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9616), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9617), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9618), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9621), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9627), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9629), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9642), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9644), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9646), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9647), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9649), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9651), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9652), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9653), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9655), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9656), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9657), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9659), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9660), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9661), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9662), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9664), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9665), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9666), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9668), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9669), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9672), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9673), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9674), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9676), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9677), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9678), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9679), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9681), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9682), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9683), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9685), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9686), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9687), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9689), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9691), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9693), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9694), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9695), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9696), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1157), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1189), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1194), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1195), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1232), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1236), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1302), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1306), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1264), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1268), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1269), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1271), new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8301), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8308), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8309), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8310), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8312), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8313), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8314), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8315), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8316), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8317), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8332), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8333), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8334), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8340), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8343), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8344), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8346), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8347), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8353), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8355), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8356), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8359), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8403), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8683), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 21, 0, 25, 35, 714, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(7005), new DateTime(2023, 10, 21, 0, 25, 35, 713, DateTimeKind.Utc).AddTicks(7009) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "guid",
                table: "publicacion_perfil_grupal");

            migrationBuilder.DropColumn(
                name: "guid",
                table: "publicacion");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9376), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9377), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7503), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7510), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7512), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7513), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7515), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7517), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7519), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7521), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7522), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7524), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7525), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7526), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7528), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7529), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7530), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7532), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7533), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7535), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7536), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7538), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7539), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7540), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7542), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7543), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7545), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7546), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7547), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7548), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7549), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7551), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7552), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7554), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7555), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7557), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7559), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7561), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7563), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7564), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7565), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7566), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7568), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7569), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7572), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7576), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7577), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7579), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7590), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7591), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7600), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7602), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7603), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7604), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7606), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7607), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7609), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7610), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7611), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7613), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7614), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7616), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7617), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7618), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7619), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7621), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7622), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7623), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7624), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7626), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7627), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7628), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7630), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7631), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7632), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7634), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7635), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7636), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7638), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7639), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7640), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7641), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7642), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7644), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7645), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7647), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7648), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7649), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7651), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7652), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7653), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7655), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7656), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7657), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7659), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7660), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7661), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7663), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7664), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7665), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7667), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7668), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7669), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7671), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7672), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7673), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7674), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9519), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9623), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9624), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9566), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9572), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6055), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6061), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6062), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6064), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6065), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6066), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6067), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6068), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6070), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6071), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6072), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6081), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6082), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6083), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6084), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6087), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6089), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6092), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6094), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6095), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6096), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6097), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6098), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6099), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6100), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6102), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6103), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6153), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6427), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 10, 18, 18, 37, 37, 499, DateTimeKind.Utc).AddTicks(4613) });
        }
    }
}
