using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeCambiosJulio20231101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3626), "usz199lz" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3637), "owt8ii95" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3640), "953463z1" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3643), "rlrw18ut" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3645), "tyr105w8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3649), "n9ex2mjw" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3652), "qm3wgshp" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2601), "isa0l548" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2626), "5usbb9ax" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2629), "e1g2ovzt" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2632), "jv4t63o2" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2634), "8ljl3v6v" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3759), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3762), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3763), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2037), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2043), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2045), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2047), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2048), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2050), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2051), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2053), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2054), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2056), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2057), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2059), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2060), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2062), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2063), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2064), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2065), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2067), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2070), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2072), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2073), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2074), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2076), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2083), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2084), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2086), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2087), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2089), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2091), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2092), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2094), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2096), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2097), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2099), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2101), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2103), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2105), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2106), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2108), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2110), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2111), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2113), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2114), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2115), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2117), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2118), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2120), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2123), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2124), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2127), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2129), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2131), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2133), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2134), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2135), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2136), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2138), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2141), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2142), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2144), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2149), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2150), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2153), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2158), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2159), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2162), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2167), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2170), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2186), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2190), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2191), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2195), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2197), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2198), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2200), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2205), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2206), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2209), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2211), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2212), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2677), "fonsgw99" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2685), "5k69iuh5" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2688), "zkcaze2s" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2691), "rlqo9gv2" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2695), "x2aaa3id" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3807), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3847), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3881), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3950), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3954), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3955), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3914), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3918), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3919), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3920), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(891), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(896), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(899), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(900), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(902), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(903), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(904), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(905), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(907), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(909), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(910), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(911), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(912), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(913), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(914), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(915), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(916), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(918), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(919), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(920), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(921), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(922), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(923), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(924), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(925), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(926), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(927), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(928), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(929), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(976), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1198), new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 31, 7, 14, 12, 54, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 31, 7, 14, 12, 53, DateTimeKind.Utc).AddTicks(9526), new DateTime(2023, 10, 31, 7, 14, 12, 53, DateTimeKind.Utc).AddTicks(9530) });
        }
    }
}
