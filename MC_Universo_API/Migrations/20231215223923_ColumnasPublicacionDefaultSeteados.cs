using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MC_Universo_API.Migrations
{
    /// <inheritdoc />
    public partial class ColumnasPublicacionDefaultSeteados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7857), "fd82b5o8" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7878), "ujaw44ks" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7881), "dee5de2t" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7883), "l5x2zb33" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7885), "fg89ef9a" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7888), "agq47hpf" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7890), "hxk48bu7" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6647), "3ojtp0wt" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6683), "cc77iuvz" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6686), "irlpgq7y" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6689), "otlomlt7" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6707), "exc3okuf" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8036), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8043), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8044), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5844), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5851), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5853), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5855), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5857), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5859), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5860), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5862), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5865), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5868), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5871), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5874), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5879), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5882), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5884), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5885), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5886), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5887), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5890), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5891), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5893), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5894), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5895), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5899), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5901), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5903), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5904), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5905), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5907), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5908), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5909), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5911), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5912), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5914), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5923), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5924), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5926), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5932), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5934), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5938), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5940), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5942), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5943), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5944), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5946), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5947), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5951), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5952), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5953), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5955), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5959), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5960), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5962), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5964), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5965), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5967), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5968), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5969), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5972), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5974), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5976), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5977), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5979), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5980), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5981), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5984), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5985), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5989), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5991), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5992), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5993), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5997), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5999), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6001), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6002), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6004), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6005), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6008), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6009), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6011), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6012), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6013), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6015), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6016), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6017), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6757), "5ui48oz8" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6766), "rgl6xh7u" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6769), "jjag6mrv" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6771), "8hcq3s44" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6773), "iih63kaz" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8135), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8139), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8187), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8192), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8274), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8282), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8283), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8284), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8286), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8287), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8289), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8226), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8229), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8230), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8231), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4267), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4273), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4274), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4275), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4276), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4278), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4279), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4280), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4281), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4283), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4284), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4285), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4296), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4297), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4298), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4299), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4300), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4302), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4303), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4304), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4305), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4306), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4307), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4308), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4309), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4310), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4311), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4312), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4313), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4315), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4316), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4705), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(2512), new DateTime(2023, 12, 15, 22, 39, 20, 18, DateTimeKind.Utc).AddTicks(2515) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "area",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2046), "kutqo7vw" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2058), "s79xwcg0" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2061), "jyi8x2d9" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2063), "if5c93gp" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2065), "e711q04i" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2068), "zzvs6pfj" });

            migrationBuilder.UpdateData(
                table: "catalogo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2069), "eiux2eir" });

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "catalogo_caminos_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "catalogo_categorias_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "catalogo_causas_landing",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(690), "xyd7wqul" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(722), "8dqzcbg6" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(725), "k7b3z8oc" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(727), "s9gorqqn" });

            migrationBuilder.UpdateData(
                table: "catalogo_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(746), "msi5c9qj" });

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "catalogo_configuraciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "catalogo_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2209), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2213), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "catalogo_estado_validacion_archivo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_documentos_eligibilidad_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "catalogo_estatus_voluntario",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "catalogo_etapa_registro_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9873), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9880), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9882), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9884), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9885), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9887), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9889), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9890), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9891), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9893), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9894), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9896), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9897), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9898), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9899), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9901), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9902), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9904), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9905), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9907), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9908), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9909), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9910), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9912), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9913), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9914), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9954), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9955), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9957), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9958), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9959), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9961), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9962), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9964), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9965), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9967), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9968), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9969), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9970), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9972), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9973), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9974), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9976), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9977), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9978), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9980), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9981), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9982), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9983), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9985), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9986), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9987), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9988), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9991), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9992), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9994), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9995), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9996), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9998), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9999), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(3), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 65,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(4), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(6), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 67,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(7), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 68,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 69,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 70,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 71,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(13), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 72,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(14), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 73,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(15), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 74,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(16), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 75,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 76,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(19), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 77,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 78,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 79,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 80,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 81,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 82,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 83,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 84,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 85,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(31), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 86,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(32), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 87,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(33), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 88,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 89,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(36), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 90,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(37), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 91,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(38), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 92,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 93,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 94,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(42), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 95,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(43), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 96,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(69), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 97,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(70), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 98,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(72), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 99,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(73), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 100,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(75), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 101,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(76), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 102,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(78), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 103,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(79), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 104,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(80), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 105,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(81), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 106,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(82), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 107,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(84), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 108,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(85), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 109,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(87), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 110,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(88), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 111,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(89), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 112,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(91), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 113,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(92), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 114,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(93), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 115,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(95), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 116,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(96), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "catalogo_etapas_chc",
                keyColumn: "id",
                keyValue: 117,
                columns: new[] { "fecha_creacion", "fecha_limite" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(97), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "catalogo_ocho_acciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_encuestas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "catalogo_preguntas_ocho_acciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "catalogo_publicaciones_perfil_grupal",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "catalogo_redes_sociales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(794), "vu5icjyl" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(803), "zysrrt8q" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(805), "f06gluud" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(808), "2ayrko1k" });

            migrationBuilder.UpdateData(
                table: "catalogo_representante",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "short_id" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(810), "v6jdocak" });

            migrationBuilder.UpdateData(
                table: "catalogo_rol_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2257), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2331), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2334), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_archivo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2336), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2377), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_comision",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2382), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2476), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2482), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2483), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2484), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2485), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2486), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2487), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_precandidatura",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2488), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2421), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2430), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2431), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipo_sesion",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_actualizacion", "fecha_creacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2432), new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_etapas_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "catalogo_tipos_preguntas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "catalogo_tokens",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "conteo_acciones_afirmativas",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "datos_esperados_por_tipo_candidatura",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "detalle_requisito_diputaciones",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 41,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 42,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 43,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 44,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 45,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 46,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 47,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 48,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 49,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 50,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 51,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 52,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 53,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 54,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 55,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 56,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 57,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 58,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 59,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 60,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 61,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 62,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 63,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 64,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 65,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 66,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 67,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 68,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 69,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 70,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 71,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 72,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 73,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 74,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 75,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 76,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 77,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 78,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 79,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 80,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 81,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 82,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 83,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 84,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 85,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 86,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 87,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 88,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 89,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 90,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 91,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 92,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 93,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 94,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 95,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 96,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 97,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 98,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 99,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 100,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 101,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 102,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 103,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 104,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 105,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 106,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 107,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 108,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 109,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 110,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 111,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 112,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 113,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 114,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 115,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 116,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 117,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 118,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 119,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 120,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 121,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 122,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 123,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 124,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 125,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 126,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 127,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 128,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 129,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 130,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 131,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 132,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 133,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 134,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 135,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 136,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 137,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 138,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 139,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 140,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 141,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 142,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 143,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 144,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 145,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 146,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 147,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 148,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 149,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 150,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 151,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 152,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 153,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 154,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 155,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 156,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 157,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 158,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 159,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 160,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 161,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 162,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 163,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 164,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 165,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 166,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 167,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 168,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 169,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 170,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 171,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 172,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 173,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 174,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 175,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 176,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 177,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 178,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 179,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 180,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 181,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 182,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 183,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 184,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 185,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 186,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 187,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 188,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 189,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 190,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 191,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 192,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 193,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 194,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 195,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 196,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 197,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 198,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 199,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 200,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 201,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 202,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 203,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 204,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 205,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 206,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 207,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 208,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 209,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 210,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 211,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 212,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 213,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 214,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 215,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 216,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 217,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 218,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 219,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 220,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 221,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 222,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 223,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 224,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 225,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 226,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 227,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 228,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 229,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 230,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 231,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 232,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 233,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 234,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 235,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 236,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 237,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 238,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 239,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 240,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 241,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 242,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 243,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 244,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 245,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 246,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 247,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 248,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 249,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 250,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 251,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 252,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 253,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 254,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 255,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 256,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 257,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 258,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 259,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 260,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 261,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 262,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 263,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 264,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 265,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 266,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 267,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 268,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 269,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 270,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 271,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 272,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 273,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 274,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 275,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 276,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 277,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 278,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 279,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 280,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 281,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 282,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 283,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 284,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 285,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 286,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 287,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 288,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 289,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 290,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 291,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 292,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 293,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 294,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 295,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 296,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 297,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 298,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 299,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "distritos_federales",
                keyColumn: "id",
                keyValue: 300,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8318), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8324), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8325), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8326), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8327), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8329), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8332), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8334), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8335), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8347), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8348), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8352), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8355), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8356), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8358), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8359), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8361), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8362), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8363), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8364), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8365), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8366), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8367), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "entidad_federativa",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "estado_circunscripcion",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "evento_tipo",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "examenes_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "perfil_grupal",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8430), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8731), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "preguntas_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "requisito_por_circunscripcion",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "respuesta_examen_chc",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_alta",
                value: new DateTime(2023, 11, 28, 20, 50, 47, 958, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion", "fecha_modificacion" },
                values: new object[] { new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(6942), new DateTime(2023, 11, 28, 20, 50, 47, 957, DateTimeKind.Utc).AddTicks(6945) });
        }
    }
}
