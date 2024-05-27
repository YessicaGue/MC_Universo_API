using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeCambiosJulio20231102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "catalogo_tipo_precandidatura",
                columns: new[] { "id", "activo", "fecha_actualizacion", "fecha_creacion", "nombre" },
                values: new object[,]
                {
                    { 4, true, new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(401), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(400), "Gubernatura" },
                    { 5, true, new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(402), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(401), "Diputación Local" },
                    { 6, true, new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(403), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(403), "Ayuntamiento" },
                    { 7, true, new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(404), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(404), "Jefe de Gobierno" },
                    { 8, true, new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(405), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(405), "Alcaldía" },
                    { 9, true, new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(406), new DateTime(2023, 11, 2, 17, 34, 54, 193, DateTimeKind.Utc).AddTicks(406), "Junta Municipal" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9165), "pxmhmssb" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9216), "d9r2q06r" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9219), "ugrx9myi" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9222), "517fhalp" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9225), "0ze35qj5" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9228), "8jvi6viv" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9231), "w1ba9dxn" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7468), "w485cxxo" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7513), "jdje1wkg" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7575), "ikedy12e" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7578), "i0t07rpp" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7591), "dvnhtgt4" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9456), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9468), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6453), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6469), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6470), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6472), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6474), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6476), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6477), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6479), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6480), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6482), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6483), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6485), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6486), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6487), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6488), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6490), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6491), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6493), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6494), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6495), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6497), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6498), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6499), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6501), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6502), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6503), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6504), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6505), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6507), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6508), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6509), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6511), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6512), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6514), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6515), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6517), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6518), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6519), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6522), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6523), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6524), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6525), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6527), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6528), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6529), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6531), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6532), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6533), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6535), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6536), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6537), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6538), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6539), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6541), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6542), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6545), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6546), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6548), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6549), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6550), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6551), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6597), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6598), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6602), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6603), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6604), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6606), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6607), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6611), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6612), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6613), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6615), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6616), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6619), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6623), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6625), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6626), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6627), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6629), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6631), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6632), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6634), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6635), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6636), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6637), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6639), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6641), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6643), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6644), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6645), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6646), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6648), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6649), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6651), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6653), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6654), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6656), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6658), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6662), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6663), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6664), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6666), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6667), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6668), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6669), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7662), "ovyt7u7g" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7676), "qujo3g6l" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7679), "2212v3u2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7682), "riv92i37" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7685), "d1ebeyos" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9526), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9592), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9598), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9665), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9779), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9788), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9789), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9723), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9726), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9727), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9728), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3445), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3458), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3460), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3461), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3465), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3467), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3468), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3470), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3473), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3475), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3476), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3477), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3482), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3483), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3484), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3485), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3494), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3496), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3497), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3499), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3503), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3504), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3505), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3506), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3513), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3514), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3515), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3516), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3524), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3525), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3526), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3528), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3618), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(4603), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(551), new DateTime(2023, 11, 1, 21, 35, 8, 644, DateTimeKind.Utc).AddTicks(556) });
        }
    }
}
