using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class MergeCecilia20230926 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "descripcion_archivo_usuario",
                table: "documento_candidatos_chc",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre_archivo_usuario",
                table: "documento_candidatos_chc",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.InsertData(
                table: "catalogo_documentos_eligibilidad_chc",
                columns: new[] { "id", "activo", "descripcion", "fecha_creacion", "nombre" },
                values: new object[] { 2, true, "Evidencias", new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6278), "Evidencias" });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5673), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5727), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5729), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5731), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5732), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5735), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5736), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5738), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5739), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5741), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5742), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5744), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5745), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5746), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5747), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5749), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5750), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5752), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5754), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5755), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5757), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5758), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5760), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5761), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5762), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5763), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5764), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5766), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5767), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5768), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5771), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5772), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5774), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5776), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5777), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5779), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5780), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5781), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5782), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5784), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5785), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5788), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5789), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5791), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5792), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5793), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5795), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5796), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5797), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5799), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5800), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5801), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5802), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5804), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5805), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5807), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5808), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5809), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5811), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5812), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5814), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5815), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5816), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5864), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5867), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5872), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5874), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5877), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5880), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5882), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5883), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5885), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5886), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5888), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5890), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5891), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5893), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5894), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5895), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5898), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5899), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5903), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5905), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5906), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5907), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5909), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5910), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5911), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5915), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5916), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5918), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5919), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5921), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5923), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5925), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5929), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4591), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4597), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4598), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4599), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4600), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4629), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4633), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4634), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4635), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4637), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4638), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4639), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4642), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4643), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4644), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4645), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4646), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4647), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4648), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4649), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4650), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4651), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4652), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4653), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4654), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4655), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4656), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4693), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4892), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(3433), new DateTime(2023, 9, 27, 3, 29, 0, 278, DateTimeKind.Utc).AddTicks(3435) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "descripcion_archivo_usuario",
                table: "documento_candidatos_chc");

            migrationBuilder.DropColumn(
                name: "nombre_archivo_usuario",
                table: "documento_candidatos_chc");

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4083), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4124), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4126), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4128), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4130), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4132), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4133), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4135), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4136), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4138), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4141), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4142), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4143), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4145), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4146), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4147), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4149), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4150), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4152), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4153), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4154), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4156), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4157), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4158), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4160), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4161), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4162), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4163), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4165), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4166), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4168), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4169), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4171), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4172), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4173), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4175), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4176), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4177), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4179), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4181), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4183), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4184), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4185), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4187), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4188), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4189), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4192), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4193), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4194), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4196), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4197), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4198), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4199), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4201), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4202), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4204), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4205), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4206), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4207), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4209), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4211), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4258), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4260), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4261), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4263), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4264), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4265), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4267), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4268), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4269), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4271), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4272), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4273), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4274), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4276), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4277), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4278), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4280), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4281), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4282), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4284), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4285), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4286), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4288), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4289), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4290), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4291), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4293), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4294), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4295), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4297), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4298), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4299), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4301), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4302), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4303), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4305), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4306), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4307), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4309), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4311), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4313), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4315), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4317), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4318), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4322), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4326), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2681), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2691), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2692), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2694), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2695), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2722), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2724), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2725), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2726), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2727), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2729), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2737), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2738), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2739), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2740), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2742), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2743), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2744), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2745), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2746), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2748), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2749), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2750), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2751), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2752), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2753), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2755), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2756), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2757), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2807), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3076), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(1325), new DateTime(2023, 9, 26, 0, 27, 46, 496, DateTimeKind.Utc).AddTicks(1329) });
        }
    }
}
