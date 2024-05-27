using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ColumnaCustomUrlAgregadaTablasPerfiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "perfil_grupal",
                comment: "Debido a que cada perfil grupal puede tener ser visitable por customurl, se establece constraint unique");

            migrationBuilder.AlterTable(
                name: "perfil",
                comment: "Debido a que cada perfil puede tener ser visitable por customurl, se establece constraint unique");

            migrationBuilder.AddColumn<string>(
                name: "custom_url",
                table: "perfil_grupal",
                type: "text",
                nullable: true,
                comment: "Esta columna permite al perfil grupal elegir un enlace personalizado");

            migrationBuilder.AddColumn<string>(
                name: "custom_url",
                table: "perfil",
                type: "text",
                nullable: true,
                comment: "Esta columna permite al perfil elegir un enlace personalizado");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6559), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6574), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6575), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5228), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5235), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5236), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5238), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5239), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5241), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5243), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5245), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5246), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5247), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5249), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5251), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5253), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5254), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5255), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5256), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5258), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5261), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5262), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5264), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5265), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5266), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5268), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5269), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5270), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5271), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5272), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5274), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5275), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5277), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5278), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5280), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5281), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5283), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5284), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5285), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5286), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5288), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5289), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5292), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5293), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5294), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5303), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5305), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5306), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5308), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5309), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5310), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5311), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5313), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5314), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5315), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5316), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5318), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5319), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5321), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5322), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5323), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5326), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5327), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5329), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5331), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5333), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5335), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5336), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5338), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5339), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5342), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5344), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5346), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5348), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5351), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5352), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5354), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5355), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5356), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5358), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5359), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5362), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5363), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5364), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5365), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5369), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5371), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5372), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5373), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5375), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5376), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5377), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5379), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5380), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5381), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5383), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5384), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5385), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5387), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5388), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5389), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5391), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5393), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5394), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5397), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6655), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6659), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6702), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6706), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6779), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6799), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6735), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6738), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6739), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6740), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3809), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3813), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3814), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3816), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3817), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3818), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3820), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3822), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3823), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3824), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3832), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3833), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3834), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3836), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3837), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3838), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3841), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3843), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3845), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3847), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3848), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3850), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3851), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3852), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "custom_url", "fecha_creacion" },
                values: new object[] { null, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "custom_url", "fecha_creacion" },
                values: new object[] { null, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "custom_url", "fecha_creacion" },
                values: new object[] { null, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "custom_url", "fecha_creacion" },
                values: new object[] { null, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "custom_url", "fecha_creacion" },
                values: new object[] { null, new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3911), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4191), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(2365), new DateTime(2023, 10, 16, 19, 57, 23, 608, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.CreateIndex(
                name: "ix_perfil_grupal_custom_url",
                table: "perfil_grupal",
                column: "custom_url",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_perfil_custom_url",
                table: "perfil",
                column: "custom_url",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_perfil_grupal_custom_url",
                table: "perfil_grupal");

            migrationBuilder.DropIndex(
                name: "ix_perfil_custom_url",
                table: "perfil");

            migrationBuilder.DropColumn(
                name: "custom_url",
                table: "perfil_grupal");

            migrationBuilder.DropColumn(
                name: "custom_url",
                table: "perfil");

            migrationBuilder.AlterTable(
                name: "perfil_grupal",
                oldComment: "Debido a que cada perfil grupal puede tener ser visitable por customurl, se establece constraint unique");

            migrationBuilder.AlterTable(
                name: "perfil",
                oldComment: "Debido a que cada perfil puede tener ser visitable por customurl, se establece constraint unique");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4443), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4452), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4454), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2946), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2953), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2954), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2956), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2957), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2959), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2961), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2962), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2964), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2965), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2967), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2968), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2969), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2971), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2972), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2973), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2974), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3002), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3004), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3005), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3007), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3008), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3009), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3011), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3012), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3013), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3014), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3016), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3017), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3018), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3020), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3021), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3022), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3024), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3026), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3027), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3028), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3030), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3031), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3032), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3033), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3034), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3036), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3037), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3038), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3040), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3041), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3042), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3044), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3045), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3046), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3047), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3049), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3050), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3051), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3052), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3054), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3055), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3057), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3058), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3059), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3060), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3062), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3063), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3064), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3066), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3067), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3069), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3070), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3071), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3073), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3075), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3077), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3078), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3079), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3081), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3082), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3083), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3084), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3086), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3087), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3137), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3139), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3142), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3143), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3146), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3147), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3148), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3149), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3151), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3152), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3153), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3156), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3160), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3161), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3162), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3164), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3165), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3166), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3168), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3169), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3170), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3172), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3174), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3175), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3177), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3179), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4491), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4517), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4521), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4523), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4550), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4558), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4612), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4616), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4617), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4584), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4585), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4586), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1398), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1414), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1415), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1417), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1418), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1419), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1420), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1421), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1422), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1424), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1425), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1437), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1438), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1441), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1442), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1443), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1444), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1445), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1446), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1447), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1449), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1450), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1451), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1452), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1453), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1454), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1455), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1482), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1484), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1485), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1486), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1528), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1784), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(196), new DateTime(2023, 10, 12, 23, 50, 44, 21, DateTimeKind.Utc).AddTicks(201) });
        }
    }
}
